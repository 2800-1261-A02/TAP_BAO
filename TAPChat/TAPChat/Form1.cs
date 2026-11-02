/*
 * TAP Chat Main Form
 * CMPE2800 - A02
 */

using System.ComponentModel;
using System.Net.Sockets;
using System.Text;
using Newtonsoft.Json;

namespace TAPChat;

public partial class TAPCHAT : Form
{
    private readonly UdpClient _client = new();



    private readonly UdpClient _listener = new(1666);

    // Chat history shown in the DataGridView.

    private readonly List<ChatRow> _chatHistory = [];

    // Known hosts shown in the ListBox.

    private readonly List<KnownHost> _knownHosts = [];

    //Dictionary used to keep known hosts unique by IP address.

    private readonly Dictionary<string, KnownHost> _knownHostMap = [];

    /*
     * Form constructor.
     * Sets up UI bindings, selection mode, event handlers,
     * and defers the receive loop until the form is shown.
     */
    public TAPCHAT()
    {
        InitializeComponent();
        Text = "TAPChat 1242 - JSON Messaging";
        UI_KnownHosts_ListBox.SelectionMode = SelectionMode.MultiSimple;

        UI_Message_TxtBox.KeyDown += UI_Message_TxtBoxOnKeyDown;
        UI_DGV.DataSource = _chatHistory;
        UI_KnownHosts_ListBox.DataSource = _knownHosts;
        Shown += Form1_Shown;
    }

    /*
     * Starts the asynchronous receive loop after the form
     * is visible. The loop is launched and allowed to run
     * for the life of the application.
     */
    private void Form1_Shown(object? sender, EventArgs e)
    {
        Task.Run(ClientRecv);
    }

    /*
     * Handles Enter key in the message textbox.
     * Builds the send target list and sends the current
     * message to every unique target.
     */
    private async void UI_Message_TxtBoxOnKeyDown(object? sender, KeyEventArgs e)
    {
        if (e.KeyCode != Keys.Enter) return;

        e.SuppressKeyPress = true;

        if (string.IsNullOrWhiteSpace(UI_Message_TxtBox.Text))
            return;

        try
        {
            HashSet<string> targets = BuildTargets();

            foreach (string host in targets)
                await ClientSend(host, UI_Message_TxtBox.Text);

            UI_Message_TxtBox.Clear();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Send Error");
        }
    }

    /*
     * Builds the full unique send target list.
     * Always includes localhost for verification.
     * Includes the manual target textbox if not blank.
     * If no known hosts are selected, all known hosts are added.
     * If known hosts are selected, only those selected hosts are added.
     */
    private HashSet<string> BuildTargets()
    {
        HashSet<string> targets = ["localhost"];

        string manualTarget = UI_TargetAddress_TxtBox.Text.Trim();
        if (!string.IsNullOrWhiteSpace(manualTarget))
            targets.Add(manualTarget);

        if (UI_KnownHosts_ListBox.SelectedItems.Count == 0)
        {
            foreach (KnownHost host in _knownHosts)
                targets.Add(host.Address);
        }
        else
        {
            foreach (KnownHost host in UI_KnownHosts_ListBox.SelectedItems)
                targets.Add(host.Address);
        }

        return targets;
    }

    /*
     * Creates a ChatPacket, serializes it to JSON,
     * converts the JSON to UTF8 bytes, and sends the packet
     * to one target host on UDP port 1666.
     */
    private async Task ClientSend(string host, string message)
    {
        ChatPacket packet = new()
        {
            Nickname = UI_Nickname_TxtBox.Text,
            Message= message
        };

        string json = JsonConvert.SerializeObject(packet);
        byte[] b = Encoding.UTF8.GetBytes(json);

        await _client.SendAsync(b, b.Length, host, 1666);
    }

    /*
     * Forever receive loop.
     * Waits asynchronously for UDP packets, deserializes the JSON,
     * updates the known-host list, chooses nickname or IP for display,
     * and inserts the newest chat message at the top of history.
     */
    private async Task ClientRecv()
    {
        while (true)
        {
            try
            {
                var result = await _listener.ReceiveAsync();

                string json = Encoding.UTF8.GetString(result.Buffer);
                string ip = result.RemoteEndPoint.Address.ToString();

                ChatPacket? packet = JsonConvert.DeserializeObject<ChatPacket>(json);
                if (packet == null) continue;

                Invoke(LearnHost, ip, packet.Nickname);

                string sender =
                    $"{(string.IsNullOrWhiteSpace(packet.Nickname) ? "<nickname>" : packet.Nickname)} <{ip}>";

                Invoke(AddChatRow, sender, packet.Message);
            }
            catch (SocketException ex)
            {
                Console.WriteLine($"Error occurred while accessing the socket: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Another error occurred: {ex.Message}");
            }
        }
    }

    /*
     * Adds a new IP address to the known-host collection if it has
     * not been seen before. If the host already exists, the nickname
     * is updated when a non-blank nickname is received.
     */
    private void LearnHost(string ip, string nickname)
    {
        if (!_knownHostMap.ContainsKey(ip))
        {
            KnownHost kh = new()
            {
                Address = ip,
                Nickname = nickname
            };

            _knownHostMap[ip] = kh;
            _knownHosts.Add(kh);
        }
        else
        {
            if (!string.IsNullOrWhiteSpace(nickname))
            {
                _knownHostMap[ip].Nickname = nickname;
            }
        }

        UI_KnownHosts_ListBox.DataSource = null;
        UI_KnownHosts_ListBox.DataSource = _knownHosts;
    }

    /*
     * Inserts a new message into the chat history.
     * Newest messages are inserted at the top of the grid.
     */
    private void AddChatRow(string sender, string message)
    {
        _chatHistory.Insert(0, new ChatRow
        {
            Timestamp = DateTime.Now.ToString("HH:mm:ss"),
            Sender = sender,
            Message = message
        });

        UI_DGV.DataSource = null;
        UI_DGV.DataSource = _chatHistory;
    }
}


namespace AssaultCubeHack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MemoryX.Memory memoryX = new MemoryX.Memory();

        private long baseAddrss;

        private void Form1_Load(object sender, EventArgs e)
        {
            if(!this.memoryX.GetProcessHandle("ac_client")) {
                MessageBox.Show("Game is not running!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            this.baseAddrss = this.memoryX.GetBaseAddress("ac_client.exe");
            this.labelBaseAddresss.Text = "0x" + this.baseAddrss.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int newHealth = int.Parse(this.textBoxHealth.Text);
                int ammo =
                this.memoryX.WriteMemoryPointer(this.baseAddrss + 0x109B74, new int[] { 0xF8 }, newHealth);
                MessageBox.Show(this.memoryX.ReadMemoryPointerInt(this.baseAddrss + 0x0010A280, new int[] { 0x8, 0xDCC, 0x34, 0x6C, 0xA4, 0x438 }).ToString());
            } catch { }
        }

        private void healthActive_Click(object sender, EventArgs e)
        {
            try
            {
                int newHealth = int.Parse(this.textBoxHealth.Text);
                this.memoryX.WriteMemoryPointer(this.baseAddrss + 0x109B74, new int[] { 0xF8 }, newHealth);
            } catch { }
        }

        private void btnAmmoActive_Click(object sender, EventArgs e)
        {
            try
            {
                int newAmmo = int.Parse(this.textBoxAmmo.Text);
                this.memoryX.WriteMemoryPointer(this.baseAddrss + 0x0010A280, new int[] { 0x8, 0xDCC, 0x34, 0x6C, 0xA4, 0x438 }, newAmmo);
            }
            catch { }
        }
    }
}
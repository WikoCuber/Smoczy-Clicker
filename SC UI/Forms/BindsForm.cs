using SC_Data;
using SC_Scripts.Scripts_Helpers;

namespace SC_UI.Forms
{
    public partial class BindsForm : Form
    {
        private readonly Data _data;
        public BindsForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

            _data = DataProvider.Get();

            #region Satrt Values
            chatBindButton.Text = ScriptsUtilities.KeysToString(_data.SlotsBinds.Chat);
            dabBindButton.Text = ScriptsUtilities.KeysToString(_data.SlotsBinds.Dab);
            eqBindButton.Text = ScriptsUtilities.KeysToString(_data.SlotsBinds.Eq);
            dropBindButton.Text = ScriptsUtilities.KeysToString(_data.SlotsBinds.Drop);
            swordBindButton.Text = ScriptsUtilities.KeysToString(_data.SlotsBinds.Sword);
            snowballBindButton.Text = ScriptsUtilities.KeysToString(_data.SlotsBinds.Snowball);
            fishingRodBindButton.Text = ScriptsUtilities.KeysToString(_data.SlotsBinds.FishingRod);
            pickaxeBindButton.Text = ScriptsUtilities.KeysToString(_data.SlotsBinds.Pickaxe);
            slot1BindButton.Text = ScriptsUtilities.KeysToString(_data.SlotsBinds.Slot1);
            slot2BindButton.Text = ScriptsUtilities.KeysToString(_data.SlotsBinds.Slot2);
            slot3BindButton.Text = ScriptsUtilities.KeysToString(_data.SlotsBinds.Slot3);
            slot4BindButton.Text = ScriptsUtilities.KeysToString(_data.SlotsBinds.Slot4);
            slot5BindButton.Text = ScriptsUtilities.KeysToString(_data.SlotsBinds.Slot5);
            blockBindButton.Text = ScriptsUtilities.KeysToString(_data.SlotsBinds.Block);
            meatBindButton.Text = ScriptsUtilities.KeysToString(_data.SlotsBinds.Meat);
            #endregion
        }

        #region Navigate
        void miningButton_Click(object sender, EventArgs e)
        {
            _data.CurrentFormType = FormType.Mining;
            Close();
        }

        void pvpButton_Click(object sender, EventArgs e)
        {
            _data.CurrentFormType = FormType.PvP;
            Close();
        }

        void othersButton_Click(object sender, EventArgs e)
        {
            _data.CurrentFormType = FormType.Others;
            Close();
        }
        void settingsButton_Click(object sender, EventArgs e)
        {
            _data.CurrentFormType = FormType.Settings;
            Close();
        }
        #endregion

        private void SetBind(Button button)
        {
            othersButton.Enabled = false;
            miningButton.Enabled = false;
            pvpButton.Enabled = false;
            settingsButton.Enabled = false;
            string oldText = button.Text;
            button.Text = "......";
            Keys currentKey = ScriptsSetup.GetKey();

            if (currentKey != Keys.Escape)
            {
                if (button == chatBindButton)
                    _data.SlotsBinds.Chat = currentKey;
                else if (button == dabBindButton)
                    _data.SlotsBinds.Dab = currentKey;
                else if (button == eqBindButton)
                    _data.SlotsBinds.Eq = currentKey;
                else if (button == dropBindButton)
                    _data.SlotsBinds.Drop = currentKey;
                else if (button == swordBindButton)
                    _data.SlotsBinds.Sword = currentKey;
                else if (button == snowballBindButton)
                    _data.SlotsBinds.Snowball = currentKey;
                else if (button == fishingRodBindButton)
                    _data.SlotsBinds.FishingRod = currentKey;
                else if (button == pickaxeBindButton)
                    _data.SlotsBinds.Pickaxe = currentKey;
                else if (button == slot1BindButton)
                    _data.SlotsBinds.Slot1 = currentKey;
                else if (button == slot2BindButton)
                    _data.SlotsBinds.Slot2 = currentKey;
                else if (button == slot3BindButton)
                    _data.SlotsBinds.Slot3 = currentKey;
                else if (button == slot4BindButton)
                    _data.SlotsBinds.Slot4 = currentKey;
                else if (button == slot5BindButton)
                    _data.SlotsBinds.Slot5 = currentKey;
                else if (button == blockBindButton)
                    _data.SlotsBinds.Block = currentKey;
                else if (button == meatBindButton)
                    _data.SlotsBinds.Meat = currentKey;

                SaveFile.Save();
                button.Text = ScriptsUtilities.KeysToString(currentKey);
            }
            else
                button.Text = oldText;

            othersButton.Enabled = true;
            miningButton.Enabled = true;
            pvpButton.Enabled = true;
            settingsButton.Enabled = true;
        }

        #region New Bind

        private void chatBindButton_Click(object sender, EventArgs e) => Task.Run(() => SetBind(chatBindButton));

        private void dabBindButton_Click(object sender, EventArgs e) => Task.Run(() => SetBind(dabBindButton));

        private void eqBindButton_Click(object sender, EventArgs e) => Task.Run(() => SetBind(eqBindButton));

        private void dropBindButton_Click(object sender, EventArgs e) => Task.Run(() => SetBind(dropBindButton));

        private void swordBindButton_Click(object sender, EventArgs e) => Task.Run(() => SetBind(swordBindButton));

        private void snowballBindButton_Click(object sender, EventArgs e) => Task.Run(() => SetBind(snowballBindButton));

        private void fishingRodBindButton_Click(object sender, EventArgs e) => Task.Run(() => SetBind(fishingRodBindButton));

        private void pickaxeBindButton_Click(object sender, EventArgs e) => Task.Run(() => SetBind(pickaxeBindButton));

        private void slot1BindButton_Click(object sender, EventArgs e) => Task.Run(() => SetBind(slot1BindButton));

        private void slot2BindButton_Click(object sender, EventArgs e) => Task.Run(() => SetBind(slot2BindButton));

        private void slot3BindButton_Click(object sender, EventArgs e) => Task.Run(() => SetBind(slot3BindButton));

        private void slot4BindButton_Click(object sender, EventArgs e) => Task.Run(() => SetBind(slot4BindButton));

        private void slot5BindButton_Click(object sender, EventArgs e) => Task.Run(() => SetBind(slot5BindButton));

        private void blockBindButton_Click(object sender, EventArgs e) => Task.Run(() => SetBind(blockBindButton));

        private void meatBindButton_Click(object sender, EventArgs e) => Task.Run(() => SetBind(meatBindButton));
        #endregion
    }
}

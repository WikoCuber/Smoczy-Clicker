using SC_Data;
using SC_UI.Helpers;

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

            SetStartValues();
        }

        private void SetStartValues()
        {
            chatBindButton.Text = ConvertHeleper.KeysToString(_data.SlotsBinds.Chat);
            dabBindButton.Text = ConvertHeleper.KeysToString(_data.SlotsBinds.Dab);
            eqBindButton.Text = ConvertHeleper.KeysToString(_data.SlotsBinds.Eq);
            dropBindButton.Text = ConvertHeleper.KeysToString(_data.SlotsBinds.Drop);
            swordBindButton.Text = ConvertHeleper.KeysToString(_data.SlotsBinds.Sword);
            snowballBindButton.Text = ConvertHeleper.KeysToString(_data.SlotsBinds.Snowball);
            fishingRodBindButton.Text = ConvertHeleper.KeysToString(_data.SlotsBinds.FishingRod);
            pickaxeBindButton.Text = ConvertHeleper.KeysToString(_data.SlotsBinds.Pickaxe);
            slot1BindButton.Text = ConvertHeleper.KeysToString(_data.SlotsBinds.Slot1);
            slot2BindButton.Text = ConvertHeleper.KeysToString(_data.SlotsBinds.Slot2);
            slot3BindButton.Text = ConvertHeleper.KeysToString(_data.SlotsBinds.Slot3);
            slot4BindButton.Text = ConvertHeleper.KeysToString(_data.SlotsBinds.Slot4);
            slot5BindButton.Text = ConvertHeleper.KeysToString(_data.SlotsBinds.Slot5);
            blockBindButton.Text = ConvertHeleper.KeysToString(_data.SlotsBinds.Block);
            meatBindButton.Text = ConvertHeleper.KeysToString(_data.SlotsBinds.Meat);
        }

        private void SetBind(Button button)
        {
            Keys key = BindHelper.Get(button, this);

            if (key == Keys.Escape)
                return;

            if (button == chatBindButton)
                _data.SlotsBinds.Chat = key;
            else if (button == dabBindButton)
                _data.SlotsBinds.Dab = key;
            else if (button == eqBindButton)
                _data.SlotsBinds.Eq = key;
            else if (button == dropBindButton)
                _data.SlotsBinds.Drop = key;
            else if (button == swordBindButton)
                _data.SlotsBinds.Sword = key;
            else if (button == snowballBindButton)
                _data.SlotsBinds.Snowball = key;
            else if (button == fishingRodBindButton)
                _data.SlotsBinds.FishingRod = key;
            else if (button == pickaxeBindButton)
                _data.SlotsBinds.Pickaxe = key;
            else if (button == slot1BindButton)
                _data.SlotsBinds.Slot1 = key;
            else if (button == slot2BindButton)
                _data.SlotsBinds.Slot2 = key;
            else if (button == slot3BindButton)
                _data.SlotsBinds.Slot3 = key;
            else if (button == slot4BindButton)
                _data.SlotsBinds.Slot4 = key;
            else if (button == slot5BindButton)
                _data.SlotsBinds.Slot5 = key;
            else if (button == blockBindButton)
                _data.SlotsBinds.Block = key;
            else if (button == meatBindButton)
                _data.SlotsBinds.Meat = key;

            SaveFile.Save();
        }

        //Navigation buttons
        private void miningNavButton_Click(object sender, EventArgs e) => Navigation.ChangeForm(FormType.Mining, this);
        private void pvpNavButton_Click(object sender, EventArgs e) => Navigation.ChangeForm(FormType.PvP, this);
        private void othersNavButton_Click(object sender, EventArgs e) => Navigation.ChangeForm(FormType.Others, this);
        private void settingsNavButton_Click(object sender, EventArgs e) => Navigation.ChangeForm(FormType.Settings, this);

        //Binds buttons
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
    }
}

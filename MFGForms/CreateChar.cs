namespace MFGForms


{
    public partial class CreateChar : Form
    {
        private string name;
        private string charOption;
        public CreateChar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (name == "" || name == null)
            {
                
                MessageBox.Show("Why No name?");
            }
            else
            {
                MessageBox.Show($"A Character With the name \"{name}\" and the class {charOption} has been created");
                
            }
        }            
       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            name = textBox1.Text;
        }

        private void radioButtonWarrior_CheckedChanged(object sender, EventArgs e)
        {
            charOption = "Warrior";
        }

        private void radioButtonMage_CheckedChanged(object sender, EventArgs e)
        {
            charOption = "Mage";
        }

        private void radioButtonArcher_CheckedChanged(object sender, EventArgs e)
        {
            charOption = "Archer";
        }
    }
}
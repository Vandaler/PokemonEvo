namespace PokemonEvo
{
    public partial class Form1 : Form
    {
        List<Pokemon> pokemons;
        Pokemon selectedPokemon;
        Pokemon monster;
        public Form1()
        {
            InitializeComponent();

            pokemons = new List<Pokemon>();
            pokemons.Add(new Victreebel());
            pokemons.Add(new Charizard());
            pokemons.Add(new Pikachu());
            pokemons.Add(new Acanine());

            monster = new Monster();
            pictureBox2.Image = monster.getImage();
            textP2Hp.Text = monster.getHP().ToString();
            textP2Name.Text = monster.getName();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[0];
            pictureBox1.Image = selectedPokemon.getImage();
            textP1Name.Text = selectedPokemon.getName();
            textP1Hp.Text = selectedPokemon.getHP().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[1];
            pictureBox1.Image = selectedPokemon.getImage();
            textP1Name.Text = selectedPokemon.getName();
            textP1Hp.Text = selectedPokemon.getHP().ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (selectedPokemon.getHP() > 0)
            {
                int damage = monster.getDefense() - selectedPokemon.getAtk();
                monster.takeDamage(damage);
                textP2Hp.Text = monster.getHP().ToString();
                
                if (monster.getHP() <= 0)
                {
                    textP2Hp.Text = "0";
                    MessageBox.Show("Monster Defeated!!");
                }
            }
            else
            {
                MessageBox.Show("Your Pokemon has no HP left.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[2];
            pictureBox1.Image = selectedPokemon.getImage();
            textP1Name.Text = selectedPokemon.getName();
            textP1Hp.Text = selectedPokemon.getHP().ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[3];
            pictureBox1.Image = selectedPokemon.getImage();
            textP1Name.Text = selectedPokemon.getName();
            textP1Hp.Text = selectedPokemon.getHP().ToString();
        }
    }
}
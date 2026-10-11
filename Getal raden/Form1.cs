using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Getal_raden
{
    public partial class Form1 : Form
    {
        private Random randomGetal = new Random();
        private int TeRadenGetal;

        public Form1()
        {
            InitializeComponent();
            TeRadenGetal = randomGetal.Next(1, 1001);
        }
        /*=======Analyse======

*1. Events: Welke gebeurtenissen heb je nodig om dit spel te maken.
        eerste moet er een getal tussen 1 en 1000 gekozen worden
        dan moet er een guess gebeuren en moeten we zien of het juist geraden is
        als het niet juist geraden is moeten we zijn of het kleiner is dan het getal
        als het niet kleiner is moeten we zien of het getal groter is
        afhangkelijk of het kleiner groter of juist is moet er een message box getoond worden
*
*2. Bewerkingen: Welke bewerkingen moet je uitvoeren in elke event. Omschrijf dus per event wat je precies moet doen.
        Random voor een radom getal
        == voor te zien of het een juist getal is
        < voor te zien of het kleiner is
        > voor te zien of het groter is
        messagebox om te laten weten of het juist, kleiner of groter is
*

*===========================*/
        private void RaadGetalButton_Click(object sender, EventArgs e)
        {
            int GeradenGetal = Convert.ToInt32(GetalTextBox.Text);
            if (GeradenGetal  == TeRadenGetal)
            {
                MessageBox.Show("Proficiat, u heeft het getal geraden.", "Getal raden", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (GeradenGetal < TeRadenGetal)
                {
                    MessageBox.Show("Helaas, het getal is hoger.", "Getal raden", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (GeradenGetal  > TeRadenGetal)
                    {
                        MessageBox.Show("Helaas, het getal is lager.", "Getal raden", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}

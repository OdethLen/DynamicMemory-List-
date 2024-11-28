namespace DynamicMemory_List_
{
    public partial class Form1 : Form
    {
        List<int> Numbers;
        public Form1()
        {
            InitializeComponent();
            Numbers = new List<int>();
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int number;
            if (int.TryParse(txtNumber.Text, out number)) // Validar si el texto es un n�mero
            {
                Numbers.Add(number); // Agregar el n�mero a la lista
                UpdateListView();    // Actualizar la visualizaci�n
                txtNumber.Clear();   // Limpiar el TextBox
                txtNumber.Focus();   // Poner el foco en el TextBox
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un n�mero v�lido.");
            }
        }


        private void UpdateListView()
        {
            lstvNumbers.Items.Clear(); // Limpiar el ListView

            foreach (int num in Numbers) // Recorrer la lista de n�meros
            {
                lstvNumbers.Items.Add(num.ToString()); // Agregar cada n�mero como un �tem en el ListView
            }
            lblCounter.Text = "Count: " + Numbers.Count;
        }
    }
  }


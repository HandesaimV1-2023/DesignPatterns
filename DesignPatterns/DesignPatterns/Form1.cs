namespace DesignPatterns
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSingleton_Click(object sender, EventArgs e)
        {
            MySingleton singleton = MySingleton.Instance;
            MySingleton singleton2 = MySingleton.Instance;
            MySingleton singleton3 = MySingleton.Instance;

            Person p = new Person();
            lock (p)
            {

            }

            //lock (typeof(Person))
            //{

            //}
        }

        private void btnMore_Click(object sender, EventArgs e)
        {
            //lock (typeof(Person))
            //{

            //}
        }
    }
}
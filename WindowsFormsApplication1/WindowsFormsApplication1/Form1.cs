using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txttheater_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            getTicketCost( );
        }  
            private double getTicketCost(int numtickets, int numtheater, bool isstudent)
        {

           
            
        if (isstudent )
            {          
        if (numtheater == 2)
           {
              return numtickets * (7.5 * .75) - 2;
              
            }
        else if (numtheater == 3)
        {
            return numtickets * 7.5 + 5;
            
        }
        else 
        {
            return numtickets * 7.5;
            
        }
        }   
        else 
        {
        if (numtheater == 2)
        {
            return numtickets * (7.5 * .75);
            
        }
        else if (numtheater == 3)
        {
            return numtickets * 7.5 + 5;
            
        }
        else 
        {
            return numtickets * 7.5;
           
        }

        }
         }
        }
    
            
        }
    


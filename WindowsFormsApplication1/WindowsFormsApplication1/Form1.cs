using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
         public static List<nodes> node_list = new List<nodes>();    
         public static List<heuristic> heuristic_list = new List<heuristic>();
         public static  List<heuristic> ListOrdered = new List<heuristic>();     
     
        public struct nodes
        {  public string first_node;
           public string second_node;
           public int cost;
        }

        public struct heuristic
        {
            public string node;
            public int node_heuristic;        
        }

        public static int line_counter = 0;
        public static string str;
        public static string total="";

        public Form1()
        {
            InitializeComponent();
        }   

        private void button2_Click(object sender, EventArgs e)
        {
            read_second_file();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            read_first_file();
        }

        public void read_second_file ()
        {          
                          openFileDialog2.Title = "Please Chose the Second File";
                          openFileDialog2.Filter = "Txt Files (*.txt)|*.txt";
                          openFileDialog2.FilterIndex = 1;
                          openFileDialog2.Multiselect = false;
                         // openFileDialog2.ShowDialog();
          
                          if (openFileDialog2.ShowDialog() == DialogResult.OK)
                          {
                              textBox2.Text = openFileDialog2.FileName.Trim();
                              StreamReader sr2 = new StreamReader(openFileDialog2.FileName);
                              while (sr2.Peek() >= 0)
                              {
                                  string str;
                                  string [] heu_array;
                                  str = sr2.ReadLine().TrimEnd();
                                  heu_array = str.Split(' ');
                                  heuristic heu = new heuristic();
                                  heu.node = heu_array[0];
                                  heu.node_heuristic = Convert.ToInt32(heu_array[1]); 
                                  heuristic_list.Add(heu);
                                //  MessageBox.Show(heu_array[1].ToString());
                              }
                          }

                          
                       
        }

        public void read_first_file() 
        {
            openFileDialog1.Title = "Please Chose the First File";
            openFileDialog1.Filter = "Txt Files (*.txt)|*.txt";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Multiselect = false;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                while (sr.Peek() >= 0)
                {
                    string str;
                    string[] nodes_array;
                    str = sr.ReadLine().TrimEnd();
                    nodes_array = str.Split(' ');
                    nodes currentnode = new nodes();
                    currentnode.first_node = nodes_array[0];
                    currentnode.second_node = nodes_array[1];
                    currentnode.cost = Convert.ToInt32(nodes_array[2]);
                    node_list.Add(currentnode);
                    line_counter++;
                    // MessageBox.Show(temp_arr[2].ToString());
                }
            }
        
        
        
        }

        public static void find_Children(string children)
        {
        
            string child = "";
            string temp2 = "";
            string temp3 = children;
            temp2 = children.Substring(0,1);          
                if (!temp2.Equals("G"))
                {
                    for (int i = 0; i < line_counter; i++)
                    {
                        if (node_list[i].first_node.Trim().Equals(temp2))
                        {
                            child += node_list[i].second_node.Trim();
                        }
                    }          
                  
                    temp3 = temp3.Substring(1);
                    child += temp3;
                    find_children_heuristic(child);
                }
              
            }       

        public void order() 
        { 
          ListOrdered =  heuristic_list.OrderBy(heuristic => heuristic.node_heuristic).ToList(); 
           
        }

        public static void find_second_node()
        {
            string first_node = "";
            for (int i = 0; i < line_counter; i++)
            {
                if (node_list[i].second_node.Equals("G"))
                {
                    first_node = node_list[i].first_node;
                    total = node_list[i].second_node + first_node;
                    find_first_node(first_node);
                
                }
            }
        }

        public static void find_first_node(String first_node)
        {
            
            String first_Node ="";

            for (int i = 0; i <  line_counter; i++)
            {
                
                if (node_list[i].second_node.Equals(first_node))
                {
                    
                    first_Node = node_list[i].first_node;
                    total = total + first_Node;                   
                    find_first_node(first_Node);
                }           
                
            }          

        }

        public static void find_children_heuristic(string children) 
        {
            int k=0;
            string[,] temp = new string[8,2];

            for (int i = 0; i < children.Length; i++)
            {
                str = children.Substring(i, 1);

                for (int j = 0; j < ListOrdered.Count ; j++)
                {
                    if (str.Equals(ListOrdered[j].node))
                    {
                        temp[k, 0] = str;
                        temp[k, 1] = (ListOrdered[j].node_heuristic).ToString();
                        k++;
                    }
                }
            }

            string childrenn = "";
            for (int i = 0; i < k; i++)
            {
                childrenn += temp[i, 0];
            }
            find_Children(childrenn);         
        }

        private static void Find_First_Node_Children()
        {
            string children = null;

            for (int i = 0; i <line_counter; i++)
            {
                if (node_list[i].first_node.Trim().Equals("A"))
                {
                    children = children + node_list[i].second_node.Trim();

                }
                else 
                {
                    break;
                }
               
            }
            find_children_heuristic(children);
        }

        public static void calculate_cost(string sol_pathh)
        {
           
            string[] temp_arr = new string[sol_pathh.Length];
            int m = 0;
            while (m <sol_pathh.Length)
            {
                temp_arr[m] = sol_pathh.Substring(m,1);
                m++;
            }
            int num = 0;

            for (int i = 0; i < temp_arr.Length; i++)
            {
                for (int j = 0; j < line_counter ; j++)
                {
                    if ((temp_arr[i].Equals(node_list[j].first_node.Trim())) && (temp_arr[i + 1].Equals(node_list[j].second_node.Trim())))
                    {
                        num += node_list[j].cost;
                    }
                }
            }

            MessageBox.Show("Solution Path :" + sol_pathh + "\n" + "Total Cost :" + num.ToString());

           
        }

        private void button3_Click(object sender, EventArgs e)
        {           
            order();
            Find_First_Node_Children();
            find_second_node();
            sol_path_order();

        }

        public void sol_path_order()
        {
           
            string sol_path = "";
            for (int i = total.Length ; i > 0 ; i--)
            {
                sol_path += total.Substring(i - 1, 1); 
            }
           

            calculate_cost(sol_path);
          
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
                panel1.Enabled = checkBox1.Checked;

                panel2.Enabled = !(checkBox1.Checked);   
            
            
        }

        private void add_node_Click(object sender, EventArgs e)
        {
            if ((first_Node.Text != string.Empty) && (second_Node.Text != string.Empty) && (cost.Text != string.Empty))
            {
                nodes nod = new nodes();
                nod.first_node = first_Node.Text.Trim();
                nod.second_node = second_Node.Text.Trim();
                nod.cost = int.Parse(cost.Text.Trim());
                node_list.Add(nod);
                line_counter++;
                first_Node.Clear();
                second_Node.Clear();
                cost.Clear();
                
            }

            else 
            {
                MessageBox.Show("Please Fill the Text areas");
            }
        }

        private void add_heu_Click(object sender, EventArgs e)
        {
            if (node.Text != string.Empty && heu.Text != string.Empty)
            {                            
                heuristic heuu = new heuristic();
                heuu.node = node.Text.Trim();                
                heuu.node_heuristic = Convert.ToInt32(heu.Text.Trim()); 
                heuristic_list.Add(heuu);
                node.Clear();
                heu.Clear();
                if (heuristic_list.Count == 2)
                {
                    MessageBox.Show (heuristic_list[1].node_heuristic.ToString());
                }

            }

            else
            {
                MessageBox.Show("Please Fill the Text areas");
            }
        }  

    }
}



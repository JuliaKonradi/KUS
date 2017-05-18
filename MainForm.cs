using Movements;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {

        private List<IMoment> Moments = new List<IMoment>();

        private DataTable MomentTable = new DataTable();

        JsonSerializer serializer = new JsonSerializer
        {
            NullValueHandling = NullValueHandling.Include,
            TypeNameHandling = TypeNameHandling.All,
            Formatting = Formatting.Indented
        };
        
            public MainForm()
        {
            InitializeComponent();
            InitializeTable();
        }
        /// <summary>
        /// Создание таблицы
        /// </summary>
        private void InitializeTable()
        {
            var columnUniformMoment = new DataColumn(" Movement Type");
            columnUniformMoment.ReadOnly = true;
            columnUniformMoment.DataType = typeof(string);
            MomentTable.Columns.Add(columnUniformMoment);
            var columnCalculateCoordinate = new DataColumn(" Calculate Coordinate");
            columnCalculateCoordinate.ReadOnly = true;
            columnCalculateCoordinate.DataType = typeof(double);
            MomentTable.Columns.Add(columnCalculateCoordinate);
            dataGridView1.DataSource = MomentTable;
            dataGridView1.Update();

        }
       
        private void ModifyRow(IMoment moment, int index)
        {
            var row = MomentTable.NewRow();
            if (moment is UniformMoment)
            {
                row[0] = "Равномерное движение";
            }
            else if (moment is AcceleratedMoment)
            {
                row[0] = "Равноускоренное движение";
            }
            else if (moment is FluctationMoment)
            {
                row[0] = "Колебательное движение";
            }
            row[1] = moment.CalculateCoordinate(10);
            MomentTable.Rows.RemoveAt(index);
            MomentTable.Rows.InsertAt(row, index);
        }

        private void AddRow(IMoment moment)
        {
            Moments.Add(moment);
            var row = MomentTable.NewRow();
            if (moment is UniformMoment)
            {
                row[0] = "Равномерное движение";
            }
            else if (moment is AcceleratedMoment)
            {
                row[0] = "Равноускоренное движение";
            }
            else if (moment is FluctationMoment)
            {
                row[0] = "Колебательное движение";
            }
            row[1] = moment.CalculateCoordinate(10);
           
            MomentTable.Rows.Add(row);
      }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new MovementForm();
           if( form.ShowDialog() == DialogResult.OK)
            {
                var moment = form.Moment;
                AddRow(moment);
            }

        }

        
        /// <summary>
        /// Кнопка изменения движений в таблице
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModifyMovements_Click(object sender, EventArgs e)
        {
            var form = new MovementForm();
            form.Moment = Moments[dataGridView1.CurrentRow.Index];
            if (form.ShowDialog() == DialogResult.OK)
            {
                var newMoment = form.Moment;
                ModifyRow(newMoment, dataGridView1.CurrentRow.Index);
                Moments.RemoveAt(dataGridView1.CurrentRow.Index);
                Moments.Insert(dataGridView1.CurrentRow.Index, newMoment);
                
             }
        }
        /// <summary>
        /// Кнопка поиска в таблице
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Search_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textSearch.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
            }
        }
        /// <summary>
        /// Кнопка удаления строки в таблице
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRemoveMomements_Click(object sender, EventArgs e)
        {
            int removeIndex = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(removeIndex);
            Moments.RemoveAt(removeIndex);
        }

        private void buttonCreateRandonData_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int j = 0; j < dataGridView1.ColumnCount; j++)
            {

                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if (rnd.Next(0) == 0)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = rnd.Next();
                    }
                    else
                        dataGridView1.Rows[i].Cells[j].Value = 0;
                }
            }

        }

       
        /// <summary>
        /// Десериализация
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openFile = new OpenFileDialog();
            openFile.Filter = "Списки движений (.imv)|*.imv";
            if (openFile.ShowDialog() ==DialogResult.OK)
            {
                using (StreamReader sw = new StreamReader(openFile.FileName))
                using(JsonReader reader = new JsonTextReader(sw))
                {
                    Moments = serializer.Deserialize<List<IMoment>>(reader);
                }
                MomentTable.Rows.Clear();
                foreach(var moment in Moments)
                {
                    var row = MomentTable.NewRow();
                    if (moment is UniformMoment)
                    {
                        row[0] = "Равномерное движение";
                    }
                    else if (moment is AcceleratedMoment)
                    {
                        row[0] = "Равноускоренное движение";
                    }
                    else if (moment is FluctationMoment)
                    {
                        row[0] = "Колебательное движение";
                    }
                    row[1] = moment.CalculateCoordinate(10);

                    MomentTable.Rows.Add(row);
                }
            }
        }
       /// <summary>
       /// Сериализация
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openFile = new SaveFileDialog();
            openFile.Filter = "Списки движений (.imv)|*.imv";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(openFile.FileName))
                using (JsonWriter reader = new JsonTextWriter(sw))
                {
                    serializer.Serialize(reader, Moments);
                }
            }
        }
    }
    }


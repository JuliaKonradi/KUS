using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Movements;


namespace WindowsFormsApp1
{
    /// <summary>
    /// Выбор типа движения
    /// </summary>
    public partial class MovementForm : Form
    {
        public IMoment Moment
        {
            get
          
            {
                if (comboBoxChooseMovementType.SelectedIndex == 0)
                {
                    var uniform = new UniformMoment();
                    uniform.Speed = Convert.ToDouble(maskedTextBoxSpeed.Text);
                    return uniform;
                }
                if (comboBoxChooseMovementType.SelectedIndex == 1)
                {
                    var uniform = new AcceleratedMoment();
                    uniform.Speed = Convert.ToDouble(maskedTextBoxSpeed.Text);
                    uniform.StartCoordinate = Convert.ToDouble(maskedTextBoxStartCoordinate.Text);
                    uniform.Acceleration = Convert.ToDouble(maskedTextBoxAcceleration.Text);
                    return uniform;
                }
                if (comboBoxChooseMovementType.SelectedIndex == 2)
                {
                    var uniform = new FluctationMoment();
                    uniform.Amplitude = Convert.ToDouble(maskedTextBoxAmplitude.Text);
                    uniform.Frequency = Convert.ToDouble(maskedTextBoxFrequency.Text);
                    uniform.StartPhase = Convert.ToDouble(maskedTextBoxStartPhase.Text);
                    return uniform;
                }
                throw new ArgumentException();
            }
            set { 
                if (value is UniformMoment)
                {
                    var UniformMoment = (UniformMoment)value;
                    comboBoxChooseMovementType.SelectedIndex = 0;
                    maskedTextBoxSpeed.Text = UniformMoment.Speed.ToString();
                }
                 else if (value is AcceleratedMoment)
                {
                    var AcceleratedMoment = (AcceleratedMoment)value;
                    comboBoxChooseMovementType.SelectedIndex = 1;
                    maskedTextBoxSpeed.Text = AcceleratedMoment.Speed.ToString();
                    maskedTextBoxStartCoordinate.Text = AcceleratedMoment.StartCoordinate.ToString();
                    maskedTextBoxAcceleration.Text = AcceleratedMoment.Acceleration.ToString();
                }
                else if(value is FluctationMoment)
                {
                    var FluctationMoment = (FluctationMoment)value;
                    comboBoxChooseMovementType.SelectedIndex = 2;
                    maskedTextBoxAmplitude.Text = FluctationMoment.Amplitude.ToString();
                    maskedTextBoxFrequency.Text = FluctationMoment.Frequency.ToString();
                    maskedTextBoxStartPhase.Text = FluctationMoment.StartPhase.ToString();   
                }
            }
        }

        public MovementForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void comboBoxChooseMovementType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBoxChooseMovementType.SelectedIndex)
            {
                case 0:
                    {
                        maskedTextBoxSpeed.Visible = true;
                        maskedTextBoxStartCoordinate.Visible = true;
                        maskedTextBoxAcceleration.Visible = false;
                        maskedTextBoxAmplitude.Visible = false;
                        maskedTextBoxFrequency.Visible = false;
                        maskedTextBoxStartPhase.Visible = false;
                        break;
                    }
                case 1:
                    {
                        maskedTextBoxSpeed.Visible = true;
                        maskedTextBoxStartCoordinate.Visible = true;
                        maskedTextBoxAcceleration.Visible = true;
                        maskedTextBoxAmplitude.Visible = false;
                        maskedTextBoxFrequency.Visible = false;
                        maskedTextBoxStartPhase.Visible = false;
                        break;
                    }
                case 2:
                    {
                        maskedTextBoxSpeed.Visible = false;
                        maskedTextBoxStartCoordinate.Visible = false;
                        maskedTextBoxAcceleration.Visible = false;
                        maskedTextBoxAmplitude.Visible = true;
                        maskedTextBoxFrequency.Visible = true;
                        maskedTextBoxStartPhase.Visible = true;
                        break;
                    }

            }
        }

        private void Amplitude_Click(object sender, EventArgs e)
        {

        }

        private void MovementForm_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBoxSpeed_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}

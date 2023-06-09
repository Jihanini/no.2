using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMPA
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void patientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.patientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet1.PatientAcceptance' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.patientAcceptanceTableAdapter.Fill(this.dataSet1.PatientAcceptance);
            // TODO: 이 코드는 데이터를 'dataSet1.Patient' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.patientTableAdapter.FillByChartNo(this.dataSet1.Patient, chartNoTextBox.Text);

            DataRowView drv = (DataRowView)patientBindingSource.Current;
            if (drv["BirthdayType"].ToString() == "S")
            {
                radS.Checked = true;
            }
            else
            {
                radL.Checked = true;
            }

            if (drv["Gender"].ToString() == "M")
            {
                radM.Checked = true;
            }
            else
            {
                radF.Checked = true;
            }
            this.patientAcceptanceTableAdapter.FillByDate(
                this.dataSet1.PatientAcceptance,
                chartNoTextBox.Text,
                DateTime.Now.Date);
            if(patientAcceptanceBindingSource.Count < 1)
            {
                patientAcceptanceBindingSource.AddNew();

                DataRowView drvAcceptatance =
                    (DataRowView)patientAcceptanceBindingSource.Current;

                drvAcceptatance["AccNo"] = "";
                drvAcceptatance["ChartNo"] = chartNoTextBox.Text;
                drvAcceptatance["AccDate"] = DateTime.Now.Date;
                drvAcceptatance["DeptCode"] = "";
                drvAcceptatance["DocNo"] = "";
                drvAcceptatance["ExamType"] = "";
                drvAcceptatance["InsuCode"] = "";

                patientAcceptanceBindingSource.EndEdit();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
           patientBindingSource.AddNew();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //현재 화면에서 선택된 행
            DataRowView drv = (DataRowView)patientBindingSource.Current;
            //생년월일

            if (radS.Checked == true)
            {
                drv["BirthdayType"] = "S";
            }
            else
            {
                drv["BirthdayType"] = "L";
            }

            if (radM.Checked == true)
            {
                drv["Gender"] = "M";
            }
            else
            {
                drv["Gender"] = "S";
            }

            //저장
            patientBindingSource.EndEdit();
            patientTableAdapter.Update(dataSet1.Patient);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //삭제
            patientBindingSource.RemoveCurrent();
            patientTableAdapter.Update(dataSet1.Patient);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //종료버튼
            this.Close();
        }
    }
}

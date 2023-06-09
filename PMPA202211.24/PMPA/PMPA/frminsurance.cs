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
    public partial class frminsurance : Form
    {
        public frminsurance()
        {
            InitializeComponent();
        }

        private void codeInsuranceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.codeInsuranceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void frminsurance_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet1.CodeInsuranceSub' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.codeInsuranceSubTableAdapter.Fill(this.dataSet1.CodeInsuranceSub);
            // TODO: 이 코드는 데이터를 'dataSet1.CodeInsurance' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.codeInsuranceTableAdapter.Fill(this.dataSet1.CodeInsurance);
            // TODO: 이 코드는 데이터를 'dataSet1.CodeInsuranceSub' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.codeInsuranceSubTableAdapter.Fill(this.dataSet1.CodeInsuranceSub);
            // TODO: 이 코드는 데이터를 'dataSet1.CodeInsurance' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.codeInsuranceTableAdapter.Fill(this.dataSet1.CodeInsurance);

        }

        private void button15_Click(object sender, EventArgs e)
        {
            codeInsuranceBindingSource.AddNew();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            codeInsuranceBindingSource.EndEdit();
            codeInsuranceTableAdapter.Update(dataSet1.CodeInsurance);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //현재 선택된 행을 삭제
            codeInsuranceBindingSource.RemoveCurrent();
            codeInsuranceTableAdapter.Update(dataSet1.CodeInsurance);

            MessageBox.Show("자료가 삭제 되었습니다.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //종료버튼
            this.Close();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            codeInsuranceSubBindingSource.AddNew();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            codeInsuranceSubBindingSource.EndEdit();
            codeInsuranceSubTableAdapter.Update(dataSet1.CodeInsuranceSub);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            codeInsuranceSubBindingSource.RemoveCurrent();
            codeInsuranceSubTableAdapter.Update(dataSet1.CodeInsuranceSub);

            MessageBox.Show("자료가 삭제 되었습니다.");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //종료버튼
            this.Close();
        }

        private void codeInsuranceBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.codeInsuranceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }
    }
}

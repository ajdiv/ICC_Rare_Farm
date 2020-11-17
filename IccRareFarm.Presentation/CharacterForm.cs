using IccRareFarm.Business;
using IccRareFarm.Repository;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace IccRareFarm.Presentation
{
    public partial class CharacterForm : Form
    {
        private readonly CharacterTool tool;
        private DataGridView characterGrid;
        private DataGridViewButtonColumn deleteCellBtn;

        private readonly string deleteCharColName = "deleteChar";
        private readonly string charIdColName = "id";

        public CharacterForm(CharacterTool charTool)
        {
            tool = charTool;

            InitializeComponent();

            deleteCellBtn = new DataGridViewButtonColumn()
            {
                Name = deleteCharColName,
                HeaderText = String.Empty,
                Text = "X",
                UseColumnTextForButtonValue = true
            };

            characterGrid.CellContentClick += new DataGridViewCellEventHandler(DeleteBtn_Click);
        }

        private void CharacterForm_Load(object sender, EventArgs e)
        {
            RepopulateCharList();

            // Add Delete to end of row once we know how many columns our table will have
            this.characterGrid.Columns.Insert(characterGrid.Columns.Count, deleteCellBtn);

            // Hide Id column
            characterGrid.Columns[charIdColName].Visible = false;
        }

        private void AddCharBtn_Click(object sender, EventArgs e)
        {
            var charName = newCharName.Text;
            tool.AddCharacter(charName);
            RepopulateCharList();
        }

        private void DeleteBtn_Click(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore clicks that are not on button cells. 
            if (e.RowIndex < 0 || e.ColumnIndex != characterGrid.Columns[deleteCharColName].Index) return;

            var id = (int)characterGrid.Rows[e.RowIndex].Cells[charIdColName].Value;
            tool.DeleteCharacter(id);
            RepopulateCharList();
        }

        private void GetAll_Click(object sender, EventArgs e)
        {
            RepopulateCharList();
        }

        private void RepopulateCharList()
        {
            var chars = tool.GetCharacterList();

            var bindingList = new BindingList<Character>(chars);
            var source = new BindingSource(bindingList, null);
            characterGrid.DataSource = source;
        }
    }
}

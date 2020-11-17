using IccRareFarm.Business;
using IccRareFarm.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IccRareFarm.Presentation
{
    public partial class CharacterForm : Form
    {
        private CharacterTool tool;

        public CharacterForm(CharacterTool charTool)
        {
            tool = charTool;

            var test = tool.GetCharacterList();

            InitializeComponent();
        }

    }
}

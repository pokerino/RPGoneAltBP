using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace RPGone
{
    public partial class Form1 : Form
    {
        dice dice = new dice();
        Stopwatch swatch = new Stopwatch();
        private character newChar = new character();
        private int totalPsi;
        private int totalCost;
        private int totalYrkeCost;
        private int totalHours;
        private int totalDays;


        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            UpdateListbox();


        }

        private void UpdateListbox()
        {
            listBox1.Items.Clear();
            totalCost = newChar.getEP();
            totalYrkeCost = newChar.getYrkeEP();
            if (newChar.KLASS == "PSI-mutant")
                totalPsi = newChar.getPsiEP();
            else
                totalPsi = 0;
            listBox1.Items.Add("Ras: " + newChar.KLASS);
            listBox1.Items.Add("Yrke: " + newChar.tYrke.name);
            listBox1.Items.Add("Ålder: " + newChar.alder);
            listBox1.Items.Add("STY: " + newChar.STY);
            listBox1.Items.Add("INT: " + newChar.INT);
            listBox1.Items.Add("PER: " + newChar.PER);
            listBox1.Items.Add("SMI: " + newChar.SMI);
            listBox1.Items.Add("STO: " + newChar.STO);
            listBox1.Items.Add("FYS: " + newChar.FYS);
            listBox1.Items.Add("MST: " + newChar.MST);
            listBox1.Items.Add("");
            listBox1.Items.Add(newChar.SB);
            listBox1.Items.Add("");
            foreach (modifier element in newChar.modifiers.OrderBy(n => n.name))
            {
                if(element.type == "CYB" || element.type=="MUT"|| element.type == "PSI"|| element.type == "ROB")
                    listBox1.Items.Add(element);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            newChar.newAttr(comboBox1.SelectedIndex);
            int tryInt;
            if (int.TryParse(textBox4.Text, out tryInt))
            {
                newChar.setAlder(tryInt);
            }
            newChar.setYrke(comboBox3.SelectedIndex);
            UpdateListbox();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            newChar.newAttr(comboBox1.SelectedIndex);
            int tryInt;
            if (int.TryParse(textBox4.Text, out tryInt))
            {
                newChar.setAlder(tryInt);
            }
            newChar.setYrke(comboBox3.SelectedIndex);
            UpdateListbox();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Visible = true;
            listBox3.Visible = true;
            listBox4.Visible = true;
            listBox5.Visible = true;
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Visible = true;
            button3.Enabled = false;
            button4.Enabled = false;
            addPSI.Enabled = false;
            removePSI.Enabled = false;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox5.Visible = true;
            infoBox.Visible = true;
            newChar.makeSkills(comboBox2.SelectedIndex);
            foreach (skill element in newChar.skills)
            {
                listBox2.Items.Add(element);
            }
            foreach (skill element in newChar.combatSkills)
            {
                listBox3.Items.Add(element);
            }
            listBox3.Items.Add(newChar.strKst);
            updateStrk();
            foreach (skill element in newChar.psiSkills)
            {
                listBox5.Items.Add(element);
            }
            textBox1.Text = totalCost.ToString() + " BP";
            if (totalYrkeCost > 0)
                textBox5.Text = totalYrkeCost.ToString() + " BP";
            else
                textBox5.Text = "0 BP";
            textBox2.Text = totalHours.ToString() + " timmar";
            psiEPBox.Text = totalPsi.ToString() + " BP";

            if (newChar.KLASS == "PSI-mutant")
            {
                addPSI.Visible = true;
                label5.Visible = true;
                psiEPBox.Visible = true;
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            infoBox.Items.Clear();
            button4.Visible = false;
            try
            {
                skill tmpSkill = newChar.skills[listBox2.SelectedIndex];
                infoBox.Items.Add(tmpSkill.name.ToUpper());
                infoBox.Items.Add("Kostnad: " + tmpSkill.checkCost());
                infoBox.Items.Add("Grund GCL: " + tmpSkill.b_gcl);
                infoBox.Items.Add("GCL: " + tmpSkill.gcl);
                infoBox.Items.Add("Ökning: " + (tmpSkill.gcl - tmpSkill.b_gcl));
                infoBox.Items.Add(tmpSkill.desc);
                if (tmpSkill.b_gcl < tmpSkill.gcl)
                    button4.Visible = true;
            }
            catch{}
            int select = listBox2.SelectedIndex;
            listBox3.ClearSelected();
            listBox5.ClearSelected();
            listBox2.SelectedIndex = select;
            button3.Enabled = true;
            button4.Enabled = true;

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            infoBox.Items.Clear();
            button4.Visible = false;
            try
            {
                skill tmpSkill;
                if (listBox3.SelectedIndex == 14)
                    tmpSkill = newChar.strKst;
                else
                    tmpSkill = newChar.combatSkills[listBox3.SelectedIndex];
                infoBox.Items.Add(tmpSkill.name.ToUpper());
                infoBox.Items.Add("Kostnad: " + tmpSkill.checkCost());
                infoBox.Items.Add("Grund GCL: " + tmpSkill.b_gcl);
                infoBox.Items.Add("GCL: " + tmpSkill.gcl);
                infoBox.Items.Add("Ökning: " + (tmpSkill.gcl - tmpSkill.b_gcl));
                infoBox.Items.Add(tmpSkill.desc);
                if (tmpSkill.b_gcl < tmpSkill.gcl)
                    button4.Visible = true;
            }
            catch { }
            if (listBox3.SelectedIndex == 14 && newChar.strKst.b_gcl < newChar.strKst.gcl)
                button4.Visible = true;
            int select = listBox3.SelectedIndex;
            listBox2.ClearSelected();
            listBox5.ClearSelected();
            listBox3.SelectedIndex = select;
            button3.Enabled = true;
            button4.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (totalCost < totalYrkeCost)
            {
                if (listBox2.SelectedIndex > -1 && newChar.skills[listBox2.SelectedIndex].checkCost() <= totalCost&& newChar.tYrke.skillList.Any(n => n.Equals(listBox2.SelectedIndex)))
                {
                    totalHours += newChar.skills[listBox2.SelectedIndex].gcl * newChar.skills[listBox2.SelectedIndex].cost;
                    totalCost -= newChar.skills[listBox2.SelectedIndex].add();
                    if (newChar.tYrke.skillList.Any(m => m.Equals(listBox2.SelectedIndex)))
                        totalYrkeCost -= newChar.skills[listBox2.SelectedIndex].checkCost();
                    listBox2.Items[listBox2.SelectedIndex] = newChar.skills[listBox2.SelectedIndex];
                }
                if (listBox3.SelectedIndex > -1 && listBox3.SelectedIndex < 14 && newChar.combatSkills[listBox3.SelectedIndex].checkCost() <= totalCost && newChar.tYrke.combatSkillList.Any(n => n.Equals(listBox3.SelectedIndex)))
                {
                    totalHours += newChar.combatSkills[listBox3.SelectedIndex].gcl *
                                    newChar.combatSkills[listBox3.SelectedIndex].cost;
                    totalCost -= newChar.combatSkills[listBox3.SelectedIndex].add();
                    if (newChar.tYrke.combatSkillList.Any(m => m.Equals(listBox3.SelectedIndex)))
                        totalYrkeCost -= newChar.combatSkills[listBox3.SelectedIndex].checkCost();
                    listBox3.Items[listBox3.SelectedIndex] = newChar.combatSkills[listBox3.SelectedIndex];
                }
                if (listBox3.SelectedIndex == 14 && newChar.strKst.checkCost() <= totalCost && newChar.tYrke.strKstEnable.Equals(true))
                {
                    totalHours += newChar.strKst.gcl * newChar.strKst.cost;
                    totalCost -= newChar.strKst.add();
                    if (newChar.tYrke.strKstEnable)
                        totalYrkeCost -= newChar.strKst.checkCost();
                    listBox3.Items[14] = newChar.strKst;
                }
            }
            else
            {
                if (listBox2.SelectedIndex > -1&& newChar.skills[listBox2.SelectedIndex].checkCost() <= totalCost)
                {
                    totalHours += newChar.skills[listBox2.SelectedIndex].gcl*newChar.skills[listBox2.SelectedIndex].cost;
                    totalCost -= newChar.skills[listBox2.SelectedIndex].add();
                    if (newChar.tYrke.skillList.Any(m => m.Equals(listBox2.SelectedIndex)))
                        totalYrkeCost -= newChar.skills[listBox2.SelectedIndex].checkCost();
                    listBox2.Items[listBox2.SelectedIndex] = newChar.skills[listBox2.SelectedIndex];
                }
                if (listBox3.SelectedIndex > -1 && listBox3.SelectedIndex < 14 && newChar.combatSkills[listBox3.SelectedIndex].checkCost() <= totalCost)
                {
                    totalHours += newChar.combatSkills[listBox3.SelectedIndex].gcl*
                                    newChar.combatSkills[listBox3.SelectedIndex].cost;
                    totalCost -= newChar.combatSkills[listBox3.SelectedIndex].add();
                    if (newChar.tYrke.combatSkillList.Any(m => m.Equals(listBox3.SelectedIndex)))
                        totalYrkeCost -= newChar.combatSkills[listBox3.SelectedIndex].checkCost();
                    listBox3.Items[listBox3.SelectedIndex] = newChar.combatSkills[listBox3.SelectedIndex];
                }
                if (listBox3.SelectedIndex == 14 && newChar.strKst.checkCost() <= totalCost)
                {
                    totalHours += newChar.strKst.gcl*newChar.strKst.cost;
                    totalCost -= newChar.strKst.add();
                    if (newChar.tYrke.strKstEnable)
                        totalYrkeCost -= newChar.strKst.checkCost();
                    listBox3.Items[14] = newChar.strKst;
                }                
            }

            totalDays = totalHours/(newChar.MST/2);
            textBox1.Text = totalCost.ToString() + " BP";
            if (totalYrkeCost > 0)
                textBox5.Text = totalYrkeCost.ToString() + " BP";
            else
                textBox5.Text = "0 BP";
            textBox2.Text = totalHours.ToString() + " timmar";
            textBox3.Text = totalDays.ToString() + " dagar";
            updateStrk();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex > -1)
            {
                int newValue = newChar.skills[listBox2.SelectedIndex].remove();
                if (newValue > 0)
                {
                    if (newChar.tYrke.skillList.Any(m => m.Equals(listBox2.SelectedIndex)))
                        totalYrkeCost += newValue;
                    totalCost += newValue;
                    totalHours -= newChar.skills[listBox2.SelectedIndex].gcl*newChar.skills[listBox2.SelectedIndex].cost;
                }
                listBox2.Items[listBox2.SelectedIndex] = newChar.skills[listBox2.SelectedIndex];
            }
            if (listBox3.SelectedIndex > -1 && listBox3.SelectedIndex < 14)
            {
                int newValue = newChar.combatSkills[listBox3.SelectedIndex].remove();
                if (newValue > 0)
                {
                    if (newChar.tYrke.combatSkillList.Any(m => m.Equals(listBox3.SelectedIndex)))
                        totalYrkeCost += newValue;
                    totalCost += newValue;
                    totalHours -= newChar.combatSkills[listBox3.SelectedIndex].gcl*newChar.combatSkills[listBox3.SelectedIndex].cost;
                }
                listBox3.Items[listBox3.SelectedIndex] = newChar.combatSkills[listBox3.SelectedIndex];
            }
            if (listBox3.SelectedIndex == 14)
            {
                int newValue = newChar.strKst.remove();
                if (newValue > 0)
                {
                    if (newChar.tYrke.strKstEnable)
                        totalYrkeCost += newValue;
                    totalCost += newValue;
                    totalHours -= newChar.strKst.gcl*newChar.strKst.cost;
                }
                listBox3.Items[14] = newChar.strKst;
            }
            totalDays = totalHours/(newChar.MST/2);
            textBox1.Text = totalCost.ToString() + " BP";
            if (totalYrkeCost > 0)
                textBox5.Text = totalYrkeCost.ToString() + " BP";
            else
                textBox5.Text = "0 BP";
            textBox2.Text = totalHours.ToString() + " timmar";
            textBox3.Text = totalDays.ToString() + " dagar";
            updateStrk();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            int tryInt;
            if (int.TryParse(textBox4.Text, out tryInt))
            {
                newChar.setAlder(tryInt);
                UpdateListbox();
            }
            else
            {
                textBox4.Text = "20";
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            newChar.setYrke(comboBox3.SelectedIndex);
            if (comboBox3.SelectedIndex == 12)
            {
                newChar.setAlder(40);
            }
            textBox4.Text = newChar.alder.ToString();
            UpdateListbox();
        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            infoBox.Items.Clear();
            removePSI.Visible = false;
            try
            {
                skill tmpSkill;
                tmpSkill = newChar.psiSkills[listBox5.SelectedIndex];
                infoBox.Items.Add(tmpSkill.name.ToUpper());
                infoBox.Items.Add("Kostnad: " + tmpSkill.checkCost());
                infoBox.Items.Add("Grund GCL: " + tmpSkill.b_gcl);
                infoBox.Items.Add("GCL: " + tmpSkill.gcl);
                infoBox.Items.Add("Ökning: " + (tmpSkill.gcl - tmpSkill.b_gcl));
                infoBox.Items.Add(tmpSkill.desc);
                if (tmpSkill.b_gcl < tmpSkill.gcl)
                    removePSI.Visible = true;
            }
            catch { }
            int select = listBox5.SelectedIndex;
            listBox2.ClearSelected();
            listBox3.ClearSelected();
            listBox5.SelectedIndex = select;
            addPSI.Enabled = true;
            removePSI.Enabled = true;
        }

        private void updateStrk()
        {
            listBox4.Items.Clear();
            foreach (maneuvers element in newChar.strKst.maneuverses)
            {
                string newManv = element.ToString();
                if (newChar.strKst.name == element.connection)
                    newManv += newChar.strKst.gcl + "%";
                if (element.connection != "none")
                    foreach (skill eSkill in newChar.skills)
                    {
                        if (eSkill.name == element.connection)
                            newManv += eSkill.gcl + "%";
                    }
                listBox4.Items.Add(newManv);
            }
        }

        private void addPSI_Click(object sender, EventArgs e)
        {
            if (listBox5.SelectedIndex > -1 && newChar.psiSkills[listBox5.SelectedIndex].checkCost()<=totalPsi)
            {
                totalPsi -= newChar.psiSkills[listBox5.SelectedIndex].add();
                listBox5.Items[listBox5.SelectedIndex] = newChar.psiSkills[listBox5.SelectedIndex];
            }
            psiEPBox.Text = totalPsi.ToString() + " BP";
        }

        private void removePSI_Click(object sender, EventArgs e)
        {
            if (listBox5.SelectedIndex > -1)
            {
                int newValue = newChar.psiSkills[listBox5.SelectedIndex].remove();
                if (newValue > 0)
                {
                    totalPsi += newValue;
                }
                listBox5.Items[listBox5.SelectedIndex] = newChar.psiSkills[listBox5.SelectedIndex];
            }
            psiEPBox.Text = totalPsi.ToString() + " BP";
        }
    }
}

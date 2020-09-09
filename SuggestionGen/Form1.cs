using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuggestionGen
{
	public partial class SuggestionGenForm : Form
	{
		public SuggestionGenForm() => InitializeComponent();

		public List<string> GenerateCode()
		{
			if (authorTextBox.Text.Length == 0) throw new CodeGenException(0, "Author TextBox is empty!");
			string[] english = englishTextBox.Text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
			string[] original = originalTextBox.Text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
			if (original.Length > 0 && english.Length != original.Length) throw new CodeGenException(1, "English and Original lengths are not the same!");
			if (original.Length > 0 && languageTextBox.Text.Length == 0) throw new CodeGenException(2, "Language TextBox is empty!");
			List<string> code = new List<string>();

			string summarySub = original.Length > 0 ? " (translated from " + languageTextBox.Text.ToLower() + ")" : "";
			code.Add("<details open><summary>Suggestion" + summarySub + "</summary>");

			string blockquoteSub = sourceLinkTextBox.Text.Length > 0 ? " cite=\"" + sourceLinkTextBox.Text + "\"" : "";
			code.Add("<blockquote" + blockquoteSub + "><p>");
			for (int i = 0; i < english.Length; i++)
			{
				string spanSub = original.Length > 0 ? " title=\"" + original[i] + "\"" : "";
				string line = "<span" + spanSub + ">" + english[i] + "</span>";
				if (i + 1 < english.Length) line += "<br/>";
				code.Add(line);
			}
			code.Add("</p></blockquote>");

			string time = createdAtTextBox.Text.Length > 0 ? ", " + createdAtTextBox.Text : "";
			string place = sourceTextTextBox.Text.Length > 0 ? ", " + sourceTextTextBox.Text : "";
			if (sourceLinkTextBox.Text.Length > 0)
				place = ", <a href=\"" + sourceLinkTextBox.Text + "\">" + place.Substring(2) + "</a>";
			code.Add("<footer>— " + authorTextBox.Text + time + place + "</footer>");

			code.Add("</details>");
			if (original.Length > 0)
			{
				code.Add("<details><summary>Suggestion (original)</summary>");

				string blockquoteSub2 = sourceLinkTextBox.Text.Length > 0 ? " cite=\"" + sourceLinkTextBox.Text + "\"" : "";
				code.Add("<blockquote" + blockquoteSub2 + "><p>");
				for (int i = 0; i < original.Length; i++)
				{
					string line = "<span title=\"" + english[i] + "\">" + original[i] + "</span>";
					if (i + 1 < original.Length) line += "<br/>";
					code.Add(line);
				}
				code.Add("</p></blockquote>");

				string time2 = createdAtTextBox.Text.Length > 0 ? ", " + createdAtTextBox.Text : "";
				string place2 = sourceTextTextBox.Text.Length > 0 ? ", " + sourceTextTextBox.Text : "";
				if (sourceLinkTextBox.Text.Length > 0)
					place2 = ", <a href=\"" + sourceLinkTextBox.Text + "\">" + place2.Substring(2) + "</a>";
				code.Add("<footer>— " + authorTextBox.Text + time2 + place2 + "</footer>");

				code.Add("</details>");
			}

			return code;
		}

		public void CopyToClipboard(object sender, EventArgs e)
		{
			try
			{
				string code = string.Join("\r\n", GenerateCode());
				Clipboard.SetText(code);
			}
			catch (CodeGenException ex)
			{
				MessageBox.Show(ex.value, "Couldn't generate HTML code!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public void ClearTextBoxes(object sender, EventArgs e) => englishTextBox.Text = originalTextBox.Text = languageTextBox.Text = authorTextBox.Text = createdAtTextBox.Text = sourceTextTextBox.Text = sourceLinkTextBox.Text = string.Empty;
	}
	public class CodeGenException : Exception
	{
		public CodeGenException(int num, string val)
		{
			number = num;
			value = val;
		}
		public int number;
		public string value;
	}
}

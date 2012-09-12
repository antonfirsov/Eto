﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Eto.Forms;

namespace Eto.Test.Sections.Serialization.Json
{
	public class Test : Panel
	{
		CheckBox myCheckBox;
		TextArea myTextArea;

		public Test ()
		{
			Eto.Json.JsonReader.Load (this);

			myCheckBox.Checked = true;
			myTextArea.Text = "This form was created via json!";
		}

		protected void HandleButtonClick (object sender, EventArgs e)
		{
			MessageBox.Show (this, "I was clicked from Json!");
		}

	}
}

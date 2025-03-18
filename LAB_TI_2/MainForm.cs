using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TI_LAB_2;

public partial class MainForm : Form
{
    readonly CipherDecipher streamCipher = new();
    public MainForm()
    {
        InitializeComponent();
    }

    void RegisterTextBox_TextChanged(object sender, EventArgs e)
    {
        LengthLabel.Text = $@"Введено регистров: {RegisterTextBox.Text.Count(x => x is '0' or '1')}";
    }

    private void CipherButton_Click(object sender, EventArgs e)
    {
        RegisterTextBox.Text = string.Join("", RegisterTextBox.Text.Where(x => x is '0' or '1'));
        if (RegisterTextBox.Text.Length != 30)
        {
            MessageBox.Show("Длина регистра должна равняться 30 состояниям!", "Внимание");
            return;
        }

        if (PlainTextBox.Text.Length is 0)
        {
            MessageBox.Show("Выберите файл, который хотите зашифровать или дешифровать!", "Внимание");
            return;
        }

        streamCipher.MakeShiftRegister(RegisterTextBox.Text);
        streamCipher.MakeEncryptionKey(streamCipher.InputData.Length);
        KeyTextBox.Text = BitArrayToStr(streamCipher.EncryptionKey);

        streamCipher.Cipher();
        CipherTextBox.Text = BitArrayToStr(streamCipher.EncryptedData);
    }

    string BitArrayToStr(BitArray array)
    {
        StringBuilder temp = new();
        if (array.Length <= 120)
        {
            foreach (bool bit in array)
            {
                temp.Append(bit ? 1 : 0);
            }       
        }
        else
        {
            temp.Append("Первые 60 битов: \n");
            for (int i = 0; i < 60; i++)
                temp.Append(array[i] ? 1 : 0);
            temp.Append($"{Environment.NewLine}Последние 60 битов: \n");
            for (int i = 60; i > 0; i--)
            {
                temp.Append(array[array.Length - i] ? 1 : 0);
            }
        }

        return temp.ToString();
    }

    private void OpenFileButton_Click(object sender, EventArgs e)
    {
        if (OpenFileDialog.ShowDialog() != DialogResult.Cancel)
        {
            StringBuilder stringBuilder = new StringBuilder();

            var bytes = File.ReadAllBytes(OpenFileDialog.FileName);
            for (int i = 0; i < bytes.Length; i++)
            {
                BitArray help = new BitArray(new[] { bytes[i] });
                foreach (bool bit in help)
                {
                    stringBuilder.Append(bit ? 1 : 0);
                }
            }

            streamCipher.InputData = new BitArray(stringBuilder.Length);
            for (int i = 0; i < streamCipher.InputData.Length; i++)
            {
                streamCipher.InputData[i] = stringBuilder[i] == '1';
            }

            PlainTextBox.Text = BitArrayToStr(streamCipher.InputData);
        }
    }

    private void SaveFileButton_Click(object sender, EventArgs e)
    {
        if (SaveFileDialog.ShowDialog() != DialogResult.Cancel)
        {
            using FileStream fileStream = new FileStream(SaveFileDialog.FileName, FileMode.Create);
            byte[] result = new byte[streamCipher.EncryptedData.Count / 8];
            streamCipher.EncryptedData.CopyTo(result, 0);
            fileStream.Write(result, 0, result.Length);
        }
    }

    private void ClearItems_Click(object sender, EventArgs e)
    {
        KeyTextBox.Clear();
        CipherTextBox.Clear();
        PlainTextBox.Clear();
    }
}
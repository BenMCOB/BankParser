using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace BankParser
{
    public class Parser
    {
        public string Parse(string filename, DateTime startDate, DateTime endDate)
        {
            XmlTextReader xmlReader = new XmlTextReader(filename);
            List<TransactionData> transactions = new List<TransactionData>();
            xmlReader.ReadToFollowing(Constants.BankTransList);

            while (!xmlReader.EOF)
            {
                xmlReader.ReadToFollowing(Constants.StatementTransaction);

                if (xmlReader.EOF)
                    break;

                TransactionData newTransaction = ReadTransactionDetails(xmlReader);

                if (newTransaction.DateMade >= startDate.Date && newTransaction.DateMade <= endDate.Date)
                {
                    transactions.Add(newTransaction);
                }
            }

            string spreadsheetText = ConvertToSpreadsheetText(transactions);

            return spreadsheetText;
        }

        private string ConvertToSpreadsheetText(List<TransactionData> transactions)
        {
            StringBuilder spreadsheetData = new StringBuilder();

            foreach (TransactionData transaction in transactions)
            {
                spreadsheetData.AppendFormat("{0}\t\t{1}\t{2}\n", transaction.Name, transaction.DateMade, transaction.Value);
            }

            return spreadsheetData.ToString();
        }

        private TransactionData ReadTransactionDetails(XmlTextReader reader)
        {
            TransactionData newData = new TransactionData();
            string currentElement = "";

            while (true)
            {
                reader.Read();

                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:
                        currentElement = reader.Name;
                        break;
                    case XmlNodeType.Text:
                        switch (currentElement)
                        {
                            case Constants.TransactionAmount:
                                newData.Value = Double.Parse(reader.Value) * -1;
                                break;
                            case Constants.DatePosted:
                                newData.DateMade = DateTime.ParseExact(reader.Value.Substring(0, Constants.DateTimeFormat.Length), Constants.DateTimeFormat, CultureInfo.InvariantCulture);
                                break;
                            case Constants.TransactionName:
                                newData.Name = reader.Value;
                                break;
                        }
                        break;
                    case XmlNodeType.EndElement:
                        if (reader.Name.Equals(Constants.StatementTransaction))
                        {
                            return newData;
                        }
                        else
                        {
                            currentElement = "";
                            break;
                        }
                }
            }
        }
    }
}

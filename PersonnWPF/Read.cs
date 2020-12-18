using OfficeOpenXml;
using System.IO;
using System.Windows.Controls;

namespace UserDetails
{
    public class readxl
    {
        public void readXLS(TextBox TextBox1, string FilePath)

        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            FileInfo excelF = new FileInfo(FilePath);
            using (var package = new ExcelPackage(excelF))
            {
                //get the first worksheet in the workbook
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                var xlWorkbook = new ExcelPackage(new FileInfo(@"C:\Users\Public\Downloads\UserInfo.xlsx"));
                ExcelWorksheet workSheet = xlWorkbook.Workbook.Worksheets[0];
                int colCount = workSheet.Dimension.End.Column;  //get Column Count
                int rowCount = workSheet.Dimension.End.Row;     //get row count
                for (int row = 1; row <= rowCount; row++)
                {
                    for (int col = 1; col <= colCount; col++)
                    {
                        TextBox1.Text = (" Row:" + row + " column:" + col + " Value:" + workSheet.Cells[row, col].Value.ToString().Trim());
                    }
                }
            }
        }
    }
}

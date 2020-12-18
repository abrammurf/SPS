using System.Collections.Generic;
using CSProject;

class PaySliP
{
    private int month;
    private int year;
    private int payMonth;
    private int payYear;

    enum MonthsOfYear { JAN = 1, FEB = 2, MAR = 3, APR = 4, MAY = 5, JUN = 6, JUL = 7, AUG = 8, SEP = 9, OCT = 10, NOV = 11, DEC = 12 }

    public void GeneratePaySlip(List <Staff> myStaff)
    {
        month = payMonth;
        year = payYear;
    }  
}
using System;
using System.Collections.Generic;

public class PhilosopherReports
{
    Dictionary<string, int> reports = new Dictionary<string, int>();
    Dictionary<string, string> status = new Dictionary<string, string>();

    Action method;

    public PhilosopherReports(Action method)
    {
        this.method = method;
    }

    public void setReport(string key, int value)
    {
        reports.Add(key, value);
    }

    public Dictionary<string, int> getReports()
    {
        return this.reports;
    }

    public Dictionary<string, string> getStatuses()
    {
        return this.status;
    }

    public int getReportValue(string key) 
    {
        int value;
        if (reports.TryGetValue(key, out value))
        {
            return value;
        }
        return 0;
    }

    public string getReportStatus(string key) 
    {
        string value;
        if (status.TryGetValue(key, out value))
        {
            return value;
        }
        return "";
    }

    public void makeChange(PhilosopherReports reports, string Name)
    {
        int value = reports.getReportValue(Name);
        value += 1;
        reports.getReports()[Name] = value;
        this.method();
    }

    public void makeStatus(PhilosopherReports reports, string Name, string status)
    {
        reports.getStatuses()[Name] = status;
        this.method();
    }

}
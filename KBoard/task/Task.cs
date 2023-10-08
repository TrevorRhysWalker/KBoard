using System;

/// <summary>
/// Summary description for Task
/// </summary>
public class Task
{
    private string name	{ set; get;	}
	private string description { set; get; }
	private DateTime createTime { get; }
	private DateTime completeTime { set; get; }
	private Status status { set; get; }

    public Task(string name, string description)
	{
		this.name = name;
		this.description = description;
		this.createTime = DateTime.NOW;
	}
}

public enum Status
{
	TODO, IN_PROGRESS, DONE;
}
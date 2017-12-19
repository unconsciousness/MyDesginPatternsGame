using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Mediator
{
	public abstract void SendMessage(Colleague colleague, string Message);
}

public class ConcreateMadiator : Mediator//Version 1.0 Mediator
{
	ConcreateColleague1 m_Colleague1 = null;
	ConcreateColleague2 m_colleague2 = null;

	public void SetColleague1(ConcreateColleague1 theColleague1)
	{
		m_Colleague1 = theColleague1;
	}

	public void SetColleague2(ConcreateColleague2 theColleague2)
	{
		m_colleague2 = theColleague2;
	}

	public override void SendMessage(Colleague colleague, string Message)//关键点！
	{
		if (colleague == m_Colleague1)
		{
			m_colleague2.Request(Message);
		}
		if (colleague == m_colleague2)
		{
			m_Colleague1.Request(Message);
		}
	}
}






public abstract class Colleague
{
	protected Mediator m_Mediator = null;

	public Colleague(Mediator theMediator)
	{
		m_Mediator = theMediator;
	}

	public abstract void Request(string Message);
}

public class ConcreateColleague1 : Colleague
{
	public ConcreateColleague1(Mediator theMediator) : base(theMediator) { }

	public void Action()
	{
		m_Mediator.SendMessage(this, "Colleague1 Send Message !");
	}

	public override void Request(string Message)
	{
		Debug.Log("ConcreateColleague1.Request : " + Message);
	}
}

public class ConcreateColleague2 : Colleague
{
	public ConcreateColleague2(Mediator theMediator) : base(theMediator) { }

	public void Action()
	{
		m_Mediator.SendMessage(this, "Colleague2 Send Message !");
	}

	public override void Request(string Message)
	{
		Debug.Log("ConcreateColleague2.Request : " + Message);
	}
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MediatorTEST : MonoBehaviour {

	// Use this for initialization
	void Start () {
		UnitTest();
	}
	
	// Update is called once per frame
	void Update () {
		
	}



	void UnitTest()
	{
		ConcreateMadiator m_Mediator = new ConcreateMadiator();//new 中介者

		ConcreateColleague1 m_Colleague1 = new ConcreateColleague1(m_Mediator);//new C1
		ConcreateColleague2 m_Colleague2 = new ConcreateColleague2(m_Mediator);//new C2

		m_Mediator.SetColleague1(m_Colleague1);//中介者设置
		m_Mediator.SetColleague2(m_Colleague2);//中介者设置

		m_Colleague1.Action();//执行
		m_Colleague2.Action();//执行
			}
}

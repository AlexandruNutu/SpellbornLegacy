using UnityEngine;
using System.Collections;

public class UserStats : MonoBehaviour {

	public string username; // numele jucatorului
	public int level;//
	public string UserClass;// pentru a sti in ce clasa este user-ul

	public float curHp;//float pt o experienta smoothly
	public float maxHp;
	public float curMana;
	public float maxMana;

	public float baseAttackPower;// pentru atacul inamicilor
	public float curAttackPower;
	public float baseAttackSpeed;
	public float curAttackSpeed;
	public float baseDodge;//poate baram atacurile inamicilor
	public float curDodge;
	public float baseHitPercent;// trebuie sa avem un procent anume
	public float curHitPercent;

	public float hpRegenTimer;
	public float hpRegenAmount;
	public float manaRegenTimer;
	public float manaRegenAmount;

	public float curXp;
	public float maxXp;

	public bool isDead;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

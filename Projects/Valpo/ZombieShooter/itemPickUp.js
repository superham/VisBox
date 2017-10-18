#pragma strict
var Gun: GameObject;
private var script;
function onTriggerEnter(hit : Collider) {
	print("trigger");
	if(hit.gameObject.name == "Ammo Box")
	{
		//print("Ammo Can");
		//script = Gun.GetComponent(PlayerShooting).Ammo;
		//script.ammo++;
		//GetComponentInChildren(TEST);//.Ammo += 100;
		Destroy(hit.gameObject);
	}

}

var cam1 : Camera;
var cam2 : Camera;
var cam3 : Camera;
 
function Start() {
    cam1.enabled = true;
    cam2.enabled = false;
    cam3.enabled = false;
}
 
function Update() {
 
    if (Input.GetKeyDown(KeyCode.Alpha1)) {
        cam1.enabled = true;
        cam2.enabled = false;
        cam3.enabled = false;
    }
    if (Input.GetKeyDown(KeyCode.Alpha2)) {
        cam1.enabled = false;
        cam2.enabled = true;
        cam3.enabled = false;
    }
    if (Input.GetKeyDown(KeyCode.Alpha3)) {
        cam1.enabled = false;
        cam2.enabled = false;
        cam3.enabled = true;
    }
}
/*Create a better solution if more than 3 camera's are needed*/

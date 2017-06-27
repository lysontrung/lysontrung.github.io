function validateForm() {
	/*lay gia tri tu html sang de check*/
	var name = document.getElementById('usernameError').value;
	var pass = document.getElementById('passwordError').value;
	var mail = document.getElementById('emailError').value;
	
	/*kiem tra du lieu*/
	if (name == ''){
		document.getElementById('usernameError').innerHTML="Username required !!!";
	}
	else if (name.length < 8){
		document.getElementById('usernameError').innerHTML="Username length min 8 character";
	}
	
	
	return false;
}
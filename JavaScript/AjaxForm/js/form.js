/*ham kiem tra do dai cua chuoi
neu dung tra ve TRUE va nguoc lai
*/
function checkLength(text){
	if (text.length < 8) {
		return false;
	}
	return true;
}
/*--------------------------*/

/*ham kiem tra chuoi co rong hay khong
neu dung tra ve TRUE va nguoc lai
phu dinh lai ham
*/
function checkEmpty(text){
	if (text == "") {
		return false;
	}
	return true;
}
/*----------------------------*/

/*ham kiem tra email dung phuong thuc TEST de kiem tra */
function validateMail(text){
    var re = /^(([^<>()\[\]\\.,;:\s@"]+(\.[^<>()\[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
    return re.test(text);
}
/*---------------------------------*/

/*khoi tao ham validate*/
function submitForm(){
	// khoi tao gia tri input luc dau la FALSE
	
	var checkUsername = false;
	var checkPassword = false;
	var checkEmail = false;
	
	/*lay id input*/
	var name = document.getElementById("username").value;
	var pass = document.getElementById("password").value;
	var mail = document.getElementById("email").value;
	var result = document.getElementById("result").value;

	/*lay id loi*/
	var nameE = document.getElementById("usernameError");
	var passE = document.getElementById("passwordError");
	var mailE = document.getElementById("emailError");
	
	if (!checkEmpty(name) && !checkEmpty(pass) && !checkEmpty(mail) ) {
		document.getElementById("username").style.background = "#eabfbf";
		document.getElementById("password").style.background = "#eabfbf";
		document.getElementById("email").style.background = "#eabfbf";
	}else {
		document.getElementById("username").style.background = "none";
		document.getElementById("password").style.background = "none";
		document.getElementById("email").style.background = "none";	
	}
		if (!checkLength(name)){
		nameE.innerHTML = "Username length < 8";
		} else{
			nameE.innerHTML = "";
			checkUsername = true;
		}

		if (!checkLength(pass)){
		passE.innerHTML = "Password length < 8";
		} else{
			passE.innerHTML = "";
			checkPassword = true;
		}
		
		if (!validateMail(mail)){
		mailE.innerHTML = "Email wrong format";
		} else{
			mailE.innerHTML = "";
			checkEmail = true;
		}
		
		/* NAME, PASS, EMAIL, neu thoa het dieu kieu thi goi request
			tham so truyen vao de so sanh la USERNAME
		*/
		if(checkUsername && checkPassword && checkEmail) {
			postAjax();
		}
		
}

function postAjax(){
	var http = new XMLHttpRequest();
	var url = "submit.php";
	var fn = document.getElementById("username").value;;
	http.open("GET", url, true);
	http.setRequestHeader("Content-type", "application/x-www-form-urlencoded");
	http.onreadystatechange = function() {
		if(http.readyState == 4 && http.status == 200) {o
			var return_data = http.responseText;
			document.getElementById("result").innerHTML = return_data;
		}	
	}
	http.send(fn);
}
	

/*-------------------------------*/

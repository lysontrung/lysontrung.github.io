/*lay cac du lieu input*/
var name = document.getElementById('username').value;
var pass = document.getElementById('password').value;
var mail = document.getElementById('email').value;
/*xet dinh dang cho email*/
var emailReg = /^([\w-\.]+@([\w-]+\.)+[\w-]{2,4})?$/;


/*lay cac du lieu bào lỗi*/
var nameE = document.getElementById('usernameError').value;
var passE = document.getElementById('passwordError').value;
var emailE = document.getElementById('emailError').value;

/*khoi tao ham validate*/
function validateForm(){
	if(name.value == "" || name.length <8){
		document.getElementById('nameE').innerHTML="Invalid username":
	}
		
	if(pass.value == "" || pass.length <8){
		document.getElementById('passE')
	}
		
	if (mail.value == password_confirmation.value) {
			password_error.textContent = "The two passwords do not match";
			password.style.border = "1px solid red";
			password_confirmation.style.border = "1px solid red";
			password.focus();
			return false;
		}
}





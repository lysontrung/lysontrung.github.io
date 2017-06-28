<?php
	$username_db = "lysontrung";
	$username = $_GET["fn"];
	// Nếu thông tin đăng nhập chính xác, trả về giá trị là 1
	if ($username == $username_db) {
		echo 1;
		exit();
	}
 
	// Nếu thông tin đăng nhập sai, trả về giá trị là 0
	echo 0;
	exit();
?>
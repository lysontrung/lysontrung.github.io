<?php
/*tao danh sach cac username
ton tai tra va TRUE va nguoc lai	
*/
	$listUsername = Array(
	"sontrung1",
	"sontrung2",
	"sontrung3"
	);
	if($_GET["username"]){
		foreach ($listUsername as $key => $username) {
			if($username === $_GET["username"]){
				echo "true";
			}
		}
	}
?>
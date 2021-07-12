<?php

$dbhost = 'localhost';
$dbname = 'qlch';
$dbuser = 'root';
$dbpass = '';

$connect = @mysqli_connect($dbhost,$dbuser,$dbpass,$dbname);


if (!$connect) {
	# code...
	echo "Error: " . mysqli_connect_error();
	exit;
}

echo "Connection Success!<br><br>";

$d1 = $_GET["ID"];
$d2 = $_GET["Types"];
//$d3 = $_GET["Bike"];
//$d4 = $_GET["States"];

$query = "INSERT INTO carinout (ID, Types) VALUES ('$d1','$d2')";
$result = mysqli_query($connect,$query);

echo "Insert success!<br>";

?>
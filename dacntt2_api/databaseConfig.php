<?php

$dbhost = 'localhost';
$dbname = 'test';
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
$d2 = $_GET["Room"];
$d3 = $_GET["Bike"];
$d4 = $_GET["States"];

$query = "INSERT INTO senddata (id, room, Bike, States) VALUES ('$d1','$d2','$d3','$d4')";
$result = mysqli_query($connect,$query);

echo "Insert success!<br>";

?>
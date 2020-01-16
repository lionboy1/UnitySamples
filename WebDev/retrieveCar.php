<?php
    $make = $_POST["make"];
	  $model = $_POST["model"];
	  $year = $_POST["year"];
	  $trim = $_POST["trim"];    
    
    $con = mysqli_connect("server_url", ""database_name", "pdatabase_assword", "database_name" );
    // Check connection
    if (mysqli_connect_errno())
    {
       echo "Failed to connect to server: " . mysqli_connect_error();
       exit;
    }
    $sql = "SELECT quantity FROM JunkCars WHERE make = '$make' AND model = '$model' AND year = '$year' AND trim = '$trim'";
    
    $result = mysqli_query($con, $sql);
    if($result->num_rows == 0)
    {
       echo "No records found.";   
    }
    else if($result->num_rows > 0)
    {
       $row = $result->fetch_assoc();
       echo $row['quantity'];
    } 
    else
    {
       echo "ERROR: Could not execute request. " . mysqli_error($con);
    }
    mysqli_close($con);
?>

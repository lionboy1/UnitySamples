<?php
    $make = $_POST["make"];
    $model = $_POST["model"];
    $trim = $_POST["trim"];
    $year = $_POST["year"];
    $quantity = $_POST["quantity"];
    
    $con=mysqli_connect(INSERT DB URL,INSERT DB USERNAME,INSERT DB PASSWORD,INSERT DB NAME);
    // Check connection
    if (mysqli_connect_errno())
    {
	   echo "Failed to connect to server: " . mysqli_connect_error();
       exit;
    }
    $sql = "UPDATE JunkCars SET quantity = '$quantity' WHERE make='$makee', model='$model', trim='$trim', year='$year'";
	
    if(mysqli_query($con, $sql))
    {
       echo "Record updated successfully.";
    } 
    else
    {
   	echo "ERROR: Could not execute request. " . mysqli_error($con);
    }
    mysqli_close($con);
?>

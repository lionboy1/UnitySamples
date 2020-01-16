<?php
        
	      $make = $_POST["make"];
        $model = $_POST["model"];
        $trim = $_POST["trim"];
        $year = $_POST["year"];
	      $quantity = $_POST["quantity"];
        
	$con=mysqli_connect("insert server name here","insert database name","insert database password","database name here");
	// Check connection
	if (mysqli_connect_errno())
	{
		echo "Failed to connect to server: " . mysqli_connect_error();
                exit;
	}
                
        $sql = "INSERT INTO JunkCars ( make, model, trim, year, quantity ) VALUES ('$make', '$model', '$trim', $year, $quantity)";
        
        if(mysqli_query($con, $sql)){
                echo "Records inserted successfully.";
        } else {
                echo "ERROR: Could not eecute $sql. " . mysqli_error($con);
        }
        
	
	mysqli_close($con);
?>

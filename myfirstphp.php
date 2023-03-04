// first php file
<?php 
    $hourlyrate	= 5.75;
	$hoursperweek = 40;
	$gross = $hourlyrate * $hoursperweek;
?>	
<-- Html code --->
<html>
<head></head>
<body>
	<p> My gross wage is <?php print("$gross"); ?>
</body>
</html>

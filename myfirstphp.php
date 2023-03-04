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
// commente
<?php 
	$myage = "None of your business <br/>";
	print($myage);
	
	$myage  = 21;
    print($myage. "<br/>");
    
	$myage = 21.75;
	print($myage);
?>	
<?php
    include("myfunctions.inc.php");
    html_header("My second function demo");
	html_h1("Tax Calculation");
    echo "I pay £" .calculatetax(15000,22,10000) . "tax";
    html_footer();
?>

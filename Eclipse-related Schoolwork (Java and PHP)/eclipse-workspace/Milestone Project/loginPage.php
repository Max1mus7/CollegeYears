<!DOCTYPE html>
<html>
<head>
<meta charset="ISO-8859-1">
<title>Insert title here</title>
</head>
<body>
	<form action="loginHandler.php" method="post">
		<h1>Login:</h1>
		<p>
			<label><b>Username: </b></label>
			<input type="text" name="username" value="Username">
		</p>
		<p>
			<label><b>Password</b></label>
			<input type="password" name="password">
		</p>
		<p>
			<input type="submit" name="submitted">
		</p>
	</form>
</body>
</html>
<?php
error_reporting(E_ALL);
ini_set('display_errors', 1);


?>

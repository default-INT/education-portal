<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">

	<title>Главная</title>
	<link rel="stylesheet" href="../view/css/main.css">
	<link rel="stylesheet" href="../view/css/font-awesome.css">
	<link rel="stylesheet" href="../view/css/form.css">
	<script type="text/javascript" src="../view/javascript/main.js"> </script>
</head>
<body>
	<header>
		<h1>PALLET PRODUCTION</h1>
		<div id="sidebar">
			<div class="toggle-btn" onclick="openMenu()">
				<span></span>
				<span></span>
				<span></span>
			</div>
			<ul>
				<li>МЕНЮ</li>
				<li><a href="">Главная</a></li>
				<li><a href="">Список всех сотрудников</a></li>
				<li><a href="">Информация о сотруднике</a></li>
				<li><a href="">Добавить сотрудника</a></li>
				<li><a href="">Добавить отчёт за день</a></li>
				<li><a href="">Контакты</a></li>
				<li><a href="">Про нас</a></li>
			</ul>
		</div>
		<div id="user">
			<i class="fa fa-user-o" aria-hidden="true">
				<a href=""> ${sessionScope.user.login}</a>
			</i>
		</div>
	</header>
	
	<main id=main>
		<article>
			<h2>ДОБАВЛЕНИЕ СОТРУДНИКА</h2>
			<hr>
			<form class="enter_form" method="post" name="enter_form">
				<ul>
				<li>
 					<input type="text" name="fullName" placeholder="ФИО сотрудника" required/>
				</li>
				<li>
					
 					<input type="text" name="bithdayYear" placeholder="Год рождения" required/>
				</li>
				<li>
					<select name="post">
						<option value="1">Сбойщик</option>
						<option value="2">Подсобник</option>
					</select>
				</li>
				<li>
 					<input type="text" name="experience" placeholder="Опыт работы (года)" required/>
				</li>
				<li>
 					<input type="text" name="phoneNumber" placeholder="(29) 817-47-53" required/>
				</li>
				<li>
 					<input type="text" name="comments" placeholder="Заметки" required/>
				</li>
				<li>
					<button class="submit" type="submit">Добавить</button>
				</li>
			</ul>
			</form>
		</article>
		
	</main>
</body>
</html>
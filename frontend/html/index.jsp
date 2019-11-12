<%--
  Created by IntelliJ IDEA.
  User: evgen
  Date: 24.07.2019
  Time: 0:12
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c" %>
<html>
<head>
    <title>Авторизация</title>
    <link rel="stylesheet" href="view/css/main.css">
    <link rel="stylesheet" href="view/css/index.css">
</head>
</head>
<body>
<h1>ДОБРО ПОЖАЛОВАТЬ<BR>PALLET PRODUCTION</h1>
<main>
    <h2>ВХОД</h2>
    <hr>
    <form class="enter_form" action="" method="post" name="enter_form">
        <ul>
            <li>
                <label for="login">Логин:</label><br>
                <input type="text" name="login" placeholder="default..." required/>
            </li>
            <li>
                <label for="password">Пароль:</label><br>
                <input type="password" name="password" required/>
            </li>       
            <c:if test="${requestScope.wrongLogPass ne null}">
            	<c:if test="${requestScope.wrongLogPass}">
            		<li style = "color: Red">Неверный логин или пароль</li>
            	</c:if>
            </c:if>
            
            <li>
                <button class="submit" type="submit">Войти</button>
            </li>
            
        </ul>
    </form>
</main>

</body>
</html>

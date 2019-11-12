function importMenu() {
	var link = document.querySelector('link[rel=import]');
	var content = link.import.querySelector('.header');
	document.body.appendChild(content.cloneNode(true));
}
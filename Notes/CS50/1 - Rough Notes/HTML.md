- Its not a programming language, meaning it does not contains methods or variables.

- HTML (Hyper Text Markup Language) : It has main two features:
	- tags
	- attributes
	
- Taking an example HTML code:
```
<!DOCTYPE html>

<html lang="en">
	<head>
		<title>
			Hello, title
		</title>
	</head>
	<body>
		hello, body
	</body>
</html>
```
Now we can use a http-server (A server is just a software running on a machine, whose purpose in life is to just handle requests and serve data) to host this html page.

I used VisualStudios **Live Server** extension to host my test.html file with the code block above^

Focusing on the html code:
-  `<!DOCTYPE html>` : This is our document type declaration, its an implicit indicator to the browser that the this file is using the latest version of html (which is version 5). 

- `<html lang="en"> ... </html>` : This is a tag in html, the tag name in this context is html. The tags used in html will generally have a closing tag like this : `</html>` unlike `<!DOCTYPE html>` which is a type declaration (not a tag) and therefore will not have a closing statement.


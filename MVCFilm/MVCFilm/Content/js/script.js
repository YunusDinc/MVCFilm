Modernizr.load([
    {
        load: 'js/jquery.min.js'
    },
    {
        // This will wait for the fallback to load and execute if it needs to.
        load: [
			'/Content/js/jquery.superfish.js', 
			'/Content/js/jquery-ui.js', 
			'/Content/js/jquery-ui.selectmenu.js',
            '/Content/js/jquery.flexslider-min.js',
            '/Content/js/jquery.quicksand.js',
            'http://www.google.com/jsapi?key=AIzaSyCZfHRnq7tigC-COeQRmoa9Cxr0vbrK6xw',
		]
    },
    {
        load: '/content/js/jquery.script.js'
    },
	{
		  test: Modernizr.mq('only all'),
		  nope: '/content/js/css3-mediaqueries.js'
	}
    ]);
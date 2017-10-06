<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="KH_Template.Home1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
		<title>Alpha</title>
		<meta http-equiv="content-type" content="text/html; charset=utf-8" />
		<meta name="description" content="" />
		<meta name="keywords" content="" />
		<!--[if lte IE 8]><script src="css/ie/html5shiv.js"></script><![endif]-->
		<script src="js/jquery.min.js"></script>
		<script src="js/jquery.dropotron.min.js"></script>
		<script src="js/jquery.scrollgress.min.js"></script>
		<script src="js/skel.min.js"></script>
		<script src="js/skel-layers.min.js"></script>
		<script src="js/init.js"></script>
		<!-- Modernizr JS -->
		<script src="js/modernizr-2.6.2.min.js"></script>
		<noscript>
			<link rel="stylesheet" href="css/skel.css" />
			<link rel="stylesheet" href="css/style.css" />
			<link rel="stylesheet" href="css/style-wide.css" />
			<!-- Animate.css -->
	<link rel="stylesheet" href="css/animate.css">
	<!-- Icomoon Icon Fonts-->
	<link rel="stylesheet" href="css/icomoon.css">
	<!-- Bootstrap  -->
	<link rel="stylesheet" href="css/bootstrap.css">
		</noscript>
		<!--[if lte IE 8]><link rel="stylesheet" href="css/ie/v8.css" /><![endif]-->
	</head>
	<body class="landing">

		<!-- Header -->
			<header id="header" class="alt">
				<h1>
                    Seekers
				</h1>
				<nav id="nav">
					<ul>
						<li><a href="index.html">Home</a></li>
						<li>
							<a href="" class="icon fa-angle-down">Services</a>
							<ul>
								<li><a href="generic.html">Generic</a></li>
								<li><a href="contact.html">Contact</a></li>
								<li><a href="elements.html">Elements</a></li>
								<li>
									<a href="">Submenu</a>
									<ul>
										<li><a href="#">Option One</a></li>
										<li><a href="#">Option Two</a></li>
										<li><a href="#">Option Three</a></li>
										<li><a href="#">Option Four</a></li>
									</ul>
								</li>
							</ul>
						</li>
						<li><a href="#" class="button">Sign Up</a></li>
					</ul>
				</nav>
			</header>
      <div class="text">
  <svg>
   <defs>
     <mask id="mask" x="0" y="0" width="100%" height="100%" >
       <!-- alpha rectangle -->
       <!-- rectángulo alfa -->
       <rect id="alpha" x="0" y="0" width="100%" height="100%"/>
       <!-- All text that you want -->
       <!-- Coloca todo el texto que necesites -->
       <text class="title" x="6%" y="0" dy="0.90em">Seekers</text>
       <text id="subtitle" x="17%" y="0" dy="3.8em">SERVICE LIKE NEVER BEFORE!</text>
     </mask>
    </defs>
    <!-- Apply color here! -->
    <!-- Color aquí -->
    <rect id="base" x="0" y="0" width="100%" height="100%"/>
  </svg>
</div>
		<!-- Banner -->
			<section id="banner">
				<%--<ul class="actions">
					<li><a href="#" class="button special">Sign Up</a></li>
					<li><a href="#" class="button">Learn More</a></li>
				</ul>--%>
			</section>

		<!-- Main -->
			<section id="main" class="container">
		
				<section class="box special">
					<header class="major">
						<h2>Introducing the ultimate mobile app
						<br />
						for doing stuff with your phone</h2>
						<p>Blandit varius ut praesent nascetur eu penatibus nisi risus faucibus nunc ornare<br />
						adipiscing nunc adipiscing. Condimentum turpis massa.</p>
					</header>
				
				</section>
				<section class="box special">
							<div id="fh5co-portfolio-section">
								<div class="container">
									<ul id="filters" class="clearfix animate-box">
										<li><span class="filter active" data-filter=".all">All</span></li>
										<li><span class="filter" data-filter=".app">Software & Technology</span></li>
										<li><span class="filter" data-filter=".card">Accounting</span></li>
										<li><span class="filter" data-filter=".icon">Real State</span></li>
										<li><span class="filter" data-filter=".logo">Advertising</span></li>
										<li><span class="filter" data-filter=".web">Education</span></li>
										<li><span class="filter" data-filter=".web">Events</span></li>
									</ul>

									<div id="portfoliolist" class="animate-box">
										
										<div class="portfolio all logo" data-cat="logo">
											<div class="portfolio-wrapper">				
												<img src="images/portfolio_pic1.jpg" alt="" />
												<div class="label">
													<div class="label-text">
														<a class="text-title">Camera</a>
														<span class="text-category">Logo</span>
													</div>
													<div class="label-bg"></div>
												</div>
											</div>
										</div>				

										<div class="portfolio all card web" data-cat="card">
											<div class="portfolio-wrapper">			
												<img src="images/portfolio_pic2.jpg" alt="" />
												<div class="label">
													<div class="label-text">
														<a class="text-title">Card</a>
														<span class="text-category">Card</span>
													</div>
													<div class="label-bg"></div>
												</div>
											</div>
										</div>		
										
										<div class="portfolio all web" data-cat="web">
											<div class="portfolio-wrapper">						
												<img src="images/portfolio_pic3.jpg" alt="" />
												<div class="label">
													<div class="label-text">
														<a class="text-title">Sonor's Design</a>
														<span class="text-category">Web design</span>
													</div>
													<div class="label-bg"></div>
												</div>
											</div>
										</div>				
										
										<div class="portfolio all card" data-cat="card">
											<div class="portfolio-wrapper">			
												<img src="images/portfolio_pic4.jpg" alt="" />
												<div class="label">
													<div class="label-text">
														<a class="text-title">Typography Company</a>
														<span class="text-category">Business card</span>
													</div>
													<div class="label-bg"></div>
												</div>
											</div>
										</div>	
													
										<div class="portfolio all app" data-cat="app">
											<div class="portfolio-wrapper">
												<img src="images/portfolio_pic5.jpg" alt="" />
												<div class="label">
													<div class="label-text">
														<a class="text-title">Weatherette</a>
														<span class="text-category">App</span>
													</div>
													<div class="label-bg"></div>
												</div>
											</div>
										</div>			
										
										<div class="portfolio all card" data-cat="card">
											<div class="portfolio-wrapper">			
												<img src="images/portfolio_pic6.jpg" alt="" />
												<div class="label">
													<div class="label-text">
														<a class="text-title">BMF</a>
														<span class="text-category">Business card</span>
													</div>
													<div class="label-bg"></div>
												</div>
											</div>
										</div>	
										
										<div class="portfolio all card" data-cat="card">
											<div class="portfolio-wrapper">			
												<img src="images/portfolio_pic7.jpg" alt="" />
												<div class="label">
													<div class="label-text">
														<a class="text-title">Techlion</a>
														<span class="text-category">Business card</span>
													</div>
													<div class="label-bg"></div>
												</div>
											</div>
										</div>	
										
										<div class="portfolio all logo" data-cat="logo">
											<div class="portfolio-wrapper">			
												<img src="images/portfolio_pic8.jpg" alt="" />
												<div class="label">
													<div class="label-text">
														<a class="text-title">KittyPic</a>
														<span class="text-category">Logo</span>
													</div>
													<div class="label-bg"></div>
												</div>
											</div>
										</div>

										<div class="portfolio all icon" data-cat="icon">
											<div class="portfolio-wrapper">			
												<img src="images/portfolio_pic9.jpg" alt="" />
												<div class="label">
													<div class="label-text">
														<a class="text-title">Domino's Pizza</a>
														<span class="text-category">Icon</span>
													</div>
													<div class="label-bg"></div>
												</div>
											</div>
										</div>																											
									</div>
								</div>
							</div>

				</section>
				<section class="box special features">
					<div class="features-row">
						<section>
							<span class="icon major fa-bolt accent2"></span>
							<h3>Magna etiam</h3>
							<p>Integer volutpat ante et accumsan commophasellus sed aliquam feugiat lorem aliquet ut enim rutrum phasellus iaculis accumsan dolore magna aliquam veroeros.</p>
						</section>
						<section>
							<span class="icon major fa-area-chart accent3"></span>
							<h3>Ipsum dolor</h3>
							<p>Integer volutpat ante et accumsan commophasellus sed aliquam feugiat lorem aliquet ut enim rutrum phasellus iaculis accumsan dolore magna aliquam veroeros.</p>
						</section>
					</div>
					<div class="features-row">
						<section>
							<span class="icon major fa-cloud accent4"></span>
							<h3>Sed feugiat</h3>
							<p>Integer volutpat ante et accumsan commophasellus sed aliquam feugiat lorem aliquet ut enim rutrum phasellus iaculis accumsan dolore magna aliquam veroeros.</p>
						</section>
						<section>
							<span class="icon major fa-lock accent5"></span>
							<h3>Enim phasellus</h3>
							<p>Integer volutpat ante et accumsan commophasellus sed aliquam feugiat lorem aliquet ut enim rutrum phasellus iaculis accumsan dolore magna aliquam veroeros.</p>
						</section>
					</div>
				</section>
					
				<div class="row">
					<div class="6u 12u(2)">

						<section class="box special">
							<span class="image featured"><img src="images/pic02.jpg" alt="" /></span>
							<h3>Sed lorem adipiscing</h3>
							<p>Integer volutpat ante et accumsan commophasellus sed aliquam feugiat lorem aliquet ut enim rutrum phasellus iaculis accumsan dolore magna aliquam veroeros.</p>
							<ul class="actions">
								<li><a href="#" class="button alt">Learn More</a></li>
							</ul>
						</section>
						
					</div>
					<div class="6u 12u(2)">

						<section class="box special">
							<span class="image featured"><img src="images/pic03.jpg" alt="" /></span>
							<h3>Accumsan integer</h3>
							<p>Integer volutpat ante et accumsan commophasellus sed aliquam feugiat lorem aliquet ut enim rutrum phasellus iaculis accumsan dolore magna aliquam veroeros.</p>
							<ul class="actions">
								<li><a href="#" class="button alt">Learn More</a></li>
							</ul>
						</section>

					</div>
				</div>

			</section>
			
		<!-- CTA -->
			<section id="cta">
				
				<h2>Sign up for beta access</h2>
				<p>Blandit varius ut praesent nascetur eu penatibus nisi risus faucibus nunc.</p>
				
				<form>
					<div class="row uniform 50%">
						<div class="8u 12u(3)">
							<input type="email" name="email" id="email" placeholder="Email Address" />
						</div>
						<div class="4u 12u(3)">
							<input type="submit" value="Sign Up" class="fit" />
						</div>
					</div>
				</form>
				
			</section>
			
		<!-- Footer -->
			<footer id="footer">
				<ul class="icons">
					<li><a href="#" class="icon fa-twitter"><span class="label">Twitter</span></a></li>
					<li><a href="#" class="icon fa-facebook"><span class="label">Facebook</span></a></li>
					<li><a href="#" class="icon fa-instagram"><span class="label">Instagram</span></a></li>
					<li><a href="#" class="icon fa-github"><span class="label">Github</span></a></li>
					<li><a href="#" class="icon fa-dribbble"><span class="label">Dribbble</span></a></li>
					<li><a href="#" class="icon fa-google-plus"><span class="label">Google+</span></a></li>
				</ul>
				<ul class="copyright">
					<li>&copy; Untitled. All rights reserved.</li><li>Design: <a href="http://html5up.net">HTML5 UP</a></li>
				</ul>
			</footer>
<!-- jQuery Easing -->
	<script src="js/jquery.easing.1.3.js"></script>
	<!-- Bootstrap -->
	<script src="js/bootstrap.min.js"></script>
	<!-- Waypoints -->
	<script src="js/jquery.waypoints.min.js"></script>
	<!-- Portfolio Filter Mixitup -->
	<script type="text/javascript" src="js/jquery.mixitup.min.js"></script>

	<!-- Main JS (Do not remove) -->
	<script src="js/main.js"></script>

	<script type="text/javascript">
	$(function () {
		
		var filterList = {
		
			init: function () {
			
				// MixItUp plugin
				// http://mixitup.io
				$('#portfoliolist').mixItUp({
  				selectors: {
    			  target: '.portfolio',
    			  filter: '.filter'	
    		  },
    		  load: {
      		  filter: '.all'  
      		}     
				});								
			
			}

		};
		
		// Run the show!
		filterList.init();

		
		
	});	
	</script>
	</body>
</html>

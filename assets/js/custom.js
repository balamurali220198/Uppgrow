  window.onload = function () {
	"use strict";

	$(".av_s_flt_lbl").click(function () {
		$(this).siblings(".av_s_flt_txtbx").focus();
		
	});
	 $('.datepicker').datepicker({
		dateFormat: 'dd - mm - yy'
		});

	$('.av_s_flt_txtbx').keyup(function () {
	
		if ($(this).val() !== "") {
			$(this).addClass("av_s_flt_txtbx_filled");
		} else {
			$(this).removeClass("av_s_flt_txtbx_filled");
		}
	});
	$('.av_s_flt_txtbx').change(function () {
	
		if ($(this).val() !== "") {
			$(this).addClass("av_s_flt_txtbx_filled");
		} else {
			$(this).removeClass("av_s_flt_txtbx_filled");
		}
	});

	$('.av_s_flt_slt').hover(function () {
		if ($(this).val() === "0") {
			$(this).removeClass("av_s_flt_txtbx_filled");
		} else {
			$(this).addClass("av_s_flt_txtbx_filled");
		}
	});


	
	
	

	        $('.av_s_flt_txtbx').each(function() {
            if ($.trim($(this).val()) !== "") {
               $(this).addClass("av_s_flt_txtbx_filled");
            }
            else {
               $(this).removeClass("av_s_flt_txtbx_filled");
            }
        });	
	 $('.av_s_flt_slt').each(function () {
		if ($(this).val() === "0") {
			$(this).removeClass("av_s_flt_txtbx_filled");
		} else {
			$(this).addClass("av_s_flt_txtbx_filled");
		}
	});
	


	
	
	
	
	$('.av_s_flt_slt').click(function () {
		if ($(this).val() === "0") {
			$(this).removeClass("av_s_flt_txtbx_filled");
		} else {
			$(this).addClass("av_s_flt_txtbx_filled");
		}
	});



	function myFunction(tp_usr_mnu) {
		if (tp_usr_mnu.matches) { // If media query matches
			$(".av_top_usr_btn").click(function () {
				$(".top_usr_mnu").toggleClass("show");
			});
		} else {
			$(".av_top_usr_btn").hover(function () {
				$(".top_usr_mnu").toggleClass("show");
			});
			$(".top_usr_mnu").hover(function () {
				$(".top_usr_mnu").toggleClass("show");
			});
		}
	}

	var tp_usr_mnu = window.matchMedia("(max-width: 900px)");
	myFunction(tp_usr_mnu); // Call listener function at run state time
	tp_usr_mnu.addListener(myFunction); // Attach listener function on changes



  };
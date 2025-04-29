<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">

<html>

<head>
	<meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1" />
	<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
	<!-- <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=0"> -->
	<meta http-equiv="pragma" content="no-cache" />
	<meta http-equiv="cache-control" content="no-cache" />
	<meta http-equiv="expires" content="0" />
	<meta name="format-detection" content="telephone=no">
	<title>LTE Wireless Router</title>
	<link href="css/stylesheet.css" rel="stylesheet" type="text/css" />
	<link rel="stylesheet" type="text/css" href="css/modaldbox.css" media="all">

	<script type="text/javascript" src="js/jquery/jquery_notion.js" language="javascript"></script>
	<script type="text/javascript">
		if (typeof jQuery == 'undefined') {
			window.location.reload(true);
		}
		var g_padWindowW = 768;
	</script>
	<script type="text/javascript" src="js/jquery/jquery.i18n.properties-1.0.4.js" language="javascript"></script>
	<script type="text/javascript" src="js/jquery/jquery.easydropdown.min.js" language="javascript"></script>
	<script type="text/javascript" src="js/jquery/jquery-form.js" language="javascript"></script>
	<script type="text/javascript" src="js/library/download.jQuery.js" language="javascript"></script>
	<script type="text/javascript" src="js/library/md5.js" language="javascript"></script>
	<script type="text/javascript" src="js/library/modaldbox.js" language="javascript"></script>
	<script type="text/javascript" src="js/library/table.js" language="javascript"></script>

	<script type="text/javascript" src="js/base/utils.js" language="javascript"></script>
	<script type="text/javascript" src="js/base/xml_helper.js" language="javascript"></script>
	<script type="text/javascript" src="js/base/ajax_calls.js" language="javascript"></script>
	<script type="text/javascript" src="js/base/config.js" language="javascript"></script>

	<script type="text/javascript" src="js/base/layout_manager.js" language="javascript"></script>
	<script type="text/javascript" src="js/base/validator.js" language="javascript"></script>
	<script type="text/javascript" src="js/control/ip_address.js" language="javascript"></script>
	<script type="text/javascript" src="js/control/mac_address.js" language="javascript"></script>

	<script type="text/javascript" src="js/panel/dashboard.js" language="javascript"></script>
	<script type="text/javascript" src="js/panel/quick_setup.js" language="javascript"></script>

	<script type="text/javascript" src="js/panel/internet/internet_connection.js" language="javascript"></script>
	<script type="text/javascript" src="js/panel/internet/pppoe.js" language="javascript"></script>
	<script type="text/javascript" src="js/panel/internet/profileManagement.js" language="javascript"></script>
	<script type="text/javascript" src="js/panel/internet/manual_network.js" language="javascript"></script>
	<script type="text/javascript" src="js/panel/internet/pin_puk.js" language="javascript"></script>
	<script type="text/javascript" src="js/panel/internet/apnInfo.js"></script>
	<script type="text/javascript" src="js/panel/internet/EthernetWAN.js"></script>
	<script type="text/javascript" src="js/panel/internet/engineeringInfo.js"></script>
	<script type="text/javascript" src="js/panel/internet/mep.js" language="javascript"></script>
	<script type="text/javascript" src="js/panel/internet/SIMCard.js"></script>
	<script type="text/javascript" src="js/panel/wifi/WLANSettings.js"></script>
	<script type="text/javascript" src="js/panel/wifi/WPSSettings.js"></script>
	<script type="text/javascript" src="js/panel/wifi/wifiFirewall.js"></script>
	<script type="text/javascript" src="js/panel/wifi/wifiMacFilter.js" language="javascript"></script>
	<script type="text/javascript" src="js/panel/wifi/wifiIpFilter.js" language="javascript"></script>
	<script type="text/javascript" src="js/panel/wifi/wifiPortMap.js" language="javascript"></script>
	<script type="text/javascript" src="js/panel/wifi/wifiDmzSet.js" language="javascript"></script>
	<script type="text/javascript" src="js/panel/wifi/wifiPortTrigger.js" language="javascript"></script>
	<script type="text/javascript" src="js/panel/wifi/wifiDnfilter.js" language="javascript"></script>
	<script type="text/javascript" src="js/panel/wifi/wifiDDNS.js"></script>
	<script type="text/javascript" src="js/panel/wifi/fireWallDos.js"></script>
	<script type="text/javascript" src="js/panel/wifi/wifiSAC.js"></script>
	<script type="text/javascript" src="js/panel/wifi/ipsec.js"></script>
	<script type="text/javascript" src="js/panel/sms/sms.js" language="javascript"></script>
	<script type="text/javascript" src="js/panel/sms/SMSSettings.js" language="javascript"></script>
	<script type="text/javascript" src="js/panel/phonebook/phonebook.js" language="javascript"></script>

	<script type="text/javascript" src="js/panel/homeNetwork/dhcp_settings.js" language="javascript"></script>
	<script type="text/javascript" src="js/panel/homeNetwork/dns_settings.js"></script>
	<script type="text/javascript" src="js/panel/homeNetwork/traffic_settings.js" language="javascript"></script>
	<script type="text/javascript" src="js/panel/homeNetwork/traffic_statistic.js" language="javascript"></script>
	<script type="text/javascript" src="js/panel/homeNetwork/connected_device.js" language="javascript"></script>
	<script type="text/javascript" src="js/panel/homeNetwork/connectdevice_traffic.js" language="javascript"></script>
	<script type="text/javascript" src="js/panel/homeNetwork/network_activity.js" language="javascript"></script>
	<script type="text/javascript" src="js/panel/homeNetwork/parentControl.js"></script>
	<script type="text/javascript" src="js/panel/router/time_setting.js" language="javascript"></script>
	<script type="text/javascript" src="js/panel/router/router_management.js" language="javascript"></script>
	<script type="text/javascript" src="js/panel/router/user_management.js" language="javascript"></script>
	<script type="text/javascript" src="js/panel/router/software_upgrade.js" language="javascript"></script>
	<script type="text/javascript" src="js/panel/router/conf_management.js" language="javascript"></script>
	<script type="text/javascript" src="js/panel/router/qos.js"></script>
	<script type="text/javascript" src="js/panel/router/UPnPSettings.js"></script>
	<script type="text/javascript" src="js/panel/router/sipalg.js"></script>
	<script type="text/javascript" src="js/panel/router/deviceManagement.js" language="javascript"></script>
	<script type="text/javascript" src="js/panel/router/tr069_setting.js" language="javascript"></script>
	<script type="text/javascript" src="js/panel/router/diagnostics.js"></script>
	<script type="text/javascript" src="js/panel/router/StaticRoute.js"></script>
	<script type="text/javascript" src="js/panel/router/workmode.js"></script>
	<script type="text/javascript" src="js/panel/router/ssh_tunnel.js"></script>
	<script type="text/javascript" src="js/panel/router/antennaSettings.js"></script>
	<script type="text/javascript" src="js/panel/stk/stk.js" language="javascript"></script>
	<script type="text/javascript" src="js/panel/stk/ussd.js" language="javascript"></script>
	<script type="text/javascript" src="js/panel/router/log_login_operation.js" language="javascript"></script>
	<script type="text/javascript" src="js/panel/router/vpn.js" language="javascript"></script>
	<script type="text/javascript" src="js/panel/router/portal.js" language="javascript"></script>
	<script type="text/javascript" src="js/panel/router/deviceInfo.js" language="javascript"></script>
	<script type="text/javascript" src="js/panel/accountManagement.js" language="javascript"></script>

	<link type="application/rss+xml" rel='alternate' href='ap-x.rss' />

	<script type="text/javascript">
		var g_platformName = 'mifi';
		var g_username = "";
		var g_wifi_switch_status = "on"
		var g_version = ''
		var g_navTimer = null;
		var noSim = false;
		var lastUnreadIds = "";
		function setLocale(value) {
			var setLangMap = new Map();
			setLangMap.put('RGW/router/language_choice_policy', value);
			PostXml("router", "set_language_choice", setLangMap);
			setLocalization(value);
			$("#tbarouter_username").focus();
		}

		function isSupport5G() {
			var ret5G = PostXml("wireless", "wifi_get_if_support_5G");
			if ($(ret5G).find('wifi_support_info').text() == 'SUPPORT_24G') {
				config_hasWIFI5G = 0
			} else if ($(ret5G).find('wifi_support_info').text() == 'SUPPORT_5G') {
				config_hasWIFI5G = 1
			}
		}

		function fotaVersionCheck(){
				PostXmlAsync("tr069","query_fota_upgrade_state",null,function(retXml){
					var responseValue = $(retXml).find("fota_upgrade_state").text();
					if(responseValue=="0"){
					PostXmlAsync("ota", "fota_check_version", null,function(retXml1){
						var otaResponse = $(retXml1).find("response").text();
						if(otaResponse =="YES"){
							//has new version
							if (g_bodyWidth < g_padWindowW) {
								ShowDlg("confirmDlg", '95%', 180);
							} else {
								ShowDlg("confirmDlg", 350, 180);
							}
							$("#lt_confirmDlg_title").text('Tip');
							$("#lt_confirmDlg_msg").text('A new software is available for update.');
							$("#lt_btnConfirmYes").val('Proceed');
							$("#lt_btnConfirmNo").hide();
							$('#mbd .close').hide();
							$("#lt_btnConfirmYes").click(function(){
								PostXml("ota","fota_upgrade_trigger");
								g_nav = "";g_firstMenu="";g_secondMenu="";
								setCurrentPage();
								showMsgBox("Tip", 'On-going software update. You may not be able to access the Internet while the updates are being downloaded or installed. Please avoid turning your modem off during this period.Your modem will reboot once the updates have been successfully installed. Please re-login after completion of software update');
								document.getElementById("btnModalOk").value = "Exit";

								$("#btnModalOk,#mbd .close").click(function(){
										setInterval(function () {
										window.location="index.html";
									}, 1000);
								})
							})
						}
					});
				}else if(responseValue=="upgrade_success"){
					showMsgBox("Tip","Your modem's software has been successfully updated.");
				}else if(responseValue=="download_start" || responseValue == "download_success"){
						g_nav = "";g_firstMenu="";g_secondMenu="";
						setCurrentPage();
						showMsgBox("Tip", 'On-going software update. You may not be able to access the Internet while the updates are being downloaded or installed. Please avoid turning your modem off during this period.Your modem will reboot once the updates have been successfully installed. Please re-login after completion of software update');
						document.getElementById("btnModalOk").value = "Exit";
					$("#btnModalOk,#mbd .close").click(function(){
							setInterval(function () {
							window.location="index.html";
						}, 1000);
					})
				}
				});			
			}

			

		function Login() {
			var username = document.getElementById("tbarouter_username").value;
			username = encodeURIComponent(username);
			var passwordOrigin = document.getElementById("tbarouter_password").value;
			var login_done;

			if (username == "" || passwordOrigin == "") {
				document.getElementById('lloginfailed').style.display = 'block';
				document.getElementById("lloginfailed").innerHTML = jQuery.i18n.prop("lloginfailed");
				return false;
			} else {
				login_done = doLogin(username, passwordOrigin);
				if ("success" == login_done) {
					isSupport5G();
					var accountXml = PostXml("account", "get_account");
					var accountList = $(accountXml).find('accounts').text();
					g_AccessAccount = accountList.split(',')[0];
					$("#divAdminApp").html(CallHtmlFile("html/adminApp.html"));
					g_username = username;
					g_pwdstrength = checkPWStrength(passwordOrigin);
					getIconInfor("1");
					if (g_navTimer) {
						clearInterval(g_navTimer);
					}
					g_navTimer = setInterval(getIconInfor, 10000);
					getProjectConfig();
					createMenuFromXML();
					createMenu(1);
					//fotaVersionCheck();
				} else if (login_done == -1) {
					document.getElementById("lloginfailed").innerHTML = jQuery.i18n.prop("lnoconn");
				} else {
					initLoginFailedStatus(login_done);
				}
			}
		}

		// login error
		function initLoginFailedStatus(login_done) {
			var login_infos = (login_done + "").split(";");
			var left_times = login_infos[0];
			var msg = jQuery.i18n.prop("lloginfailed_left_times") + " " + left_times + " " + jQuery.i18n.prop("lloginfailed_time");
			if (left_times == 0) {
				var left_time = login_infos[1];
				var login_times = left_time - 1;
				$("#btnSignIn").prop("disabled", "disabled");
				$("#tbarouter_username, #tbarouter_password").prop("readonly", true);
				var login_failed_timeIntervalId = setInterval(function () {
					login_times -= 1;
					msg = jQuery.i18n.prop("lloginfailed_left_time") + " " + login_times + "s";
					document.getElementById('lloginfailed').style.display = 'block';
					document.getElementById("lloginfailed").innerHTML = msg;
					if (login_times == 0) {
						clearInterval(login_failed_timeIntervalId);
						$("#btnSignIn").prop("disabled", false);
						$("#tbarouter_username, #tbarouter_password").prop("readonly", false);
						document.getElementById('lloginfailed').style.display = 'none';
					}
				}, 1000);
			} else {
				document.getElementById('lloginfailed').style.display = 'block';
				document.getElementById("lloginfailed").innerHTML = msg;
			}
		}

		function checkEnter(e) {
			var characterCode;
			if (e && e.which) {
				e = e
				characterCode = e.which
			} else {
				e = event
				characterCode = e.keyCode
			}
			if (characterCode == 13) {
				Login();
			}
		}

		function hideError() {
			document.getElementById('lloginfailed').style.display = 'none';
		}

		function checkIfLogin() {
			var url = window.location.protocol + "//" + window.location.host + getHeader("GET", "iflogin");
			var result = sendAjax(url);
			return result;
		}
		// login status
		function getLoginStatus() {
			var url = window.location.protocol + '//' + window.location.host + getHeader('GET', 'login_status');
			var result = sendAjax1(url);
			if (result && result != "error") {
				var res = result.split(",");
				var status = res[0];
				status = status.split("=")[1];
				if (status == 0) {

					return "success";
				}
				if (status == "5") {
					var left_time = res[1].split("=")[1];
					var left_times = 5 - status;
					initLoginFailedStatus(left_times + ";" + left_time);
				}
			}
		}

		function initIndex() {
			bodyWidth = parseInt(document.body.offsetWidth);
			var isLogined = checkIfLogin();
			var page = '';
			if (isLogined) {
				page = $(isLogined).find('html').text();
			}
			//forbid mouse button
			var bodyObj = document.body;
			if (bodyObj && forbiddenMouseRightBtn) {
				bodyObj.oncontextmenu = function () {
					return false
				};
			}
			g_version = GetBrowserType();
			if ("IE6" == g_version) {
				var fileref = document.createElement('script');
				fileref.setAttribute("type", "text/javascript");
				fileref.setAttribute("src", 'js/jquery/jquery.bgiframe.min.js');
				document.getElementsByTagName("head")[0].appendChild(fileref);
			}
			setLocalization('en');
			getLoginStatus();
			if (page && page.indexOf('500 - Internal Server Error') < 0 && $(isLogined).find('html').text() != ':::') {
				isSupport5G();
				var pages = page.split(':');
				var nav_ = pages[0];
				var firstMenu_ = pages[1];
				var secondMenu_ = pages[2];
				g_pwdstrength = pages[3];
				g_username = $(isLogined).find('name').text();
				document.getElementById("divAdminApp").innerHTML = CallHtmlFile("html/adminApp.html");
				document.getElementById("divAdminApp").style.display = 'block';
				createMenuFromXML();
				getIconInfor("1");
				if (g_navTimer) {
					clearInterval(g_navTimer);
				}
				g_navTimer = setInterval(getIconInfor, 10000);
				if (nav_ == "quicksetup") {
					quickSetup(firstMenu_);
					return;
				}
				createMenu(nav_);
				if (secondMenu_) {
					displaySubForm(firstMenu_);
					displayForm(secondMenu_, '1');
				} else if (firstMenu_) {
					displayForm(firstMenu_);
				}
				//fotaVersionCheck();
			} else {
				$("#divAdminApp").show();
				if (bodyWidth > 430) {
					ShowDlg("confirmDlg", 1000, 386);
				} else {
					ShowDlg("confirmDlg", '95%', 154);
				}
				$("#mbox #lt_btnConfirmNo").hide();
				$("#lt_confirmDlg_msg").html('Notice is hereby given to all subscribers of the PLDT Inc. ("PLDT") Prepaid Home WiFi service <br>("Prepaid Home WiFi Subscribers") that PLDT shall transfer all the Prepaid Home WiFi Subscribers to Smart Communications, Inc. ("SMART") effective March 1, 2021.<br> As of said date, the Prepaid Home WiFi Subscribers and all other rights, interests, and obligations of PLDT related thereunder, shall be assigned to and assumed by SMART. Effective February 1, 2021, SMART shall be the Personal Information Controller of all Prepaid Home WiFi Subscribers.');
				$("#lt_confirmDlg_title").html("PLDT INC.<br> NOTICE TO PREPAID HOME WIFI SUBSCRIBERS");
				$("#lt_btnConfirmYes").val("Continue");

				$('#lt_btnConfirmYes').click(function () {
					CloseDlg()
				});
			}
		}

		function getIconInfor(type) {
			GetWifiSwitchStatus(type);
			GetSimStatus(type);
			GetLinkContext(type);
			GetConnectedDeviceInfo(type);
			GetUnReadSms();
		}

		function GetWifiSwitchStatus(type) {
			PostXmlAsync("wireless", "wifi_get_detail", null, function (data) {
				var g_wifi24g_switch_status = $(data).find("AP0").find("wifi_if_24G").find("switch").text();
				if (config_hasWIFI5G) {
					var g_wifi5g_switch_status = $(data).find("AP1").find("wifi_if_5G").find("switch").text();
					if (g_wifi24g_switch_status == "off" && g_wifi5g_switch_status == "off") {
						g_wifi_switch_status = "off"
					} else {
						g_wifi_switch_status = "on"
					}
				} else {
					g_wifi_switch_status = g_wifi24g_switch_status
				}

			}, type);
		}

		function GetSimStatus(type) {
			PostXmlAsync("sim", "get_sim_status", null, function (retXml) {
				initSimStatus(retXml);
			}, type);
		}

		function initSimStatus(retXml) {
			var simStatus = $(retXml).find("sim_status").text();
			var pinStatus = $(retXml).find("pin_status").text();
			var pnStatus = $(retXml).find("pn_status").text();
			if (0 == simStatus) {
				noSim = true;
				$("#imgSIMstatus").attr("src", "images/sim_not_detected.png");
				$("#imgSIMstatus").attr("title", "No SIM");
				$("#imgSIMstatus").removeClass("cursorPointer");
				$("#imgSIMstatus").click(function () {
					return;
				});
			} else if (1 == simStatus) {
				if (2 == pinStatus || 3 == pinStatus) {
					$("#imgSIMstatus").attr("src", "images/simLocked.png");
					$("#imgSIMstatus").attr("title", "SIM Locked");
					$("#imgSIMstatus").addClass("cursorPointer");
					$("#imgSIMstatus").click(function () {
						dashboardOnClick('mPinPuk');
					});
				} else if (4 == pinStatus) {
					var perso_substate = $(retXml).find("perso_substate").text();
					if (perso_substate == "3" || perso_substate == "8") {
						$("#imgSIMstatus").attr("src", "images/simLocked.png");
						$("#imgSIMstatus").attr("title", "Invalid SIM");
						$("#imgSIMstatus").addClass("cursorPointer");
						$("#imgSIMstatus").click(function () {
							dashboardOnClick('mPinPuk');
						});
					} else {
						$("#imgSIMstatus").attr("src", "images/sim_detected.png");
						$("#imgSIMstatus").attr("title", "SIM Ready");
						$("#imgSIMstatus").removeClass("cursorPointer");
						$("#imgSIMstatus").click(function () {
							return;
						})
					}
				} else {
					$("#imgSIMstatus").attr("src", "images/sim_detected.png");
					$("#imgSIMstatus").attr("title", "SIM Ready");
					$("#imgSIMstatus").removeClass("cursorPointer");
					$("#imgSIMstatus").click(function () {
						return;
					})
				}

			} else if (2 == simStatus) {
				$("#imgSIMstatus").attr("src", "images/simLocked.png");
				$("#imgSIMstatus").attr("title", "Invalid SIM");
				$("#imgSIMstatus").addClass("cursorPointer");
				$("#imgSIMstatus").click(function () {
					dashboardOnClick('mPinPuk');
				});
			} else if (3 == simStatus) {
				$("#imgSIMstatus").attr("src", "images/simLocked.png");
				$("#imgSIMstatus").attr("title", "Invalid SIM");
				$("#imgSIMstatus").addClass("cursorPointer");
				$("#imgSIMstatus").click(function () {
					dashboardOnClick('mPinPuk');
				});
			}
		}

		function GetLinkContext(type) {
			PostXmlAsync("cm", "get_link_context", null, function (retXml) {
				initLinkContext(retXml);
			}, type);
		}

		function initLinkContext(retXml) {
			var phoneNum = $(retXml).find("MSISDN").text();
			if (!noSim) {
				$("#txtUserPhoneNumber").show();
				if (phoneNum && phoneNum != "") {
					$("#txtUserPhoneNumber").text(phoneNum);
				} else {
					$("#txtUserPhoneNumber").text("N/A");
				}
			} else {
				$("#txtUserPhoneNumber").hide();
			}

			g_imei = $(retXml).find("IMEI").text();
			var IMSI = $(retXml).find("IMSI").text();
			var networkOperate = "";
			if (1 == $(retXml).find("roaming").text()) {
				networkOperate = $(retXml).find("roaming_network_name").text();
			} else {
				networkOperate = $(retXml).find("network_name").text();
			}
			if (networkOperate && networkOperate.startsWith("80")) {
				networkOperate = UniDecode(networkOperate.substr(2));
			}
			if (networkOperate) {
				$('#txtNetworkOperator').show();
				if (IMSI.substring(0, 5) == '51503') {
					$("#txtNetworkOperator").text('Smart');
				} else if (IMSI.substring(0, 5) == '51505') {
					$("#txtNetworkOperator").text('SUN');
				} else {
					$("#txtNetworkOperator").text(networkOperate);
				}
			} else {
				$('#txtNetworkOperator').hide();
			}
			//<sys_mode/> <!-- 0: no service  1:2G3G  2:LTE-->
			var cellularSysNetworkMode = $(retXml).find("sys_mode").text();
			//<data_mode/> <!-- 1: GPRS 2: EDGE 9: HSPDA 10: HSUPA 11:HSPA 14: LTE -->
			var cellularDataConnMode = $(retXml).find("data_mode").text();
			if (0 == cellularSysNetworkMode) {
				$("#txtSystemNetworkMode").text(jQuery.i18n.prop("lt_dashbd_NoService"));
			} else if (1 == cellularSysNetworkMode) {
				if (cellularDataConnMode != 1 && cellularDataConnMode != 2 && cellularDataConnMode != 16) {
					//3G
					$("#txtSystemNetworkMode").text("3G");
				} else {
					$("#txtSystemNetworkMode").text("2G");
				}
			} else if (2 == cellularSysNetworkMode) {
				$("#txtSystemNetworkMode").text("LTE");
			}

			var rssi = $(retXml).find("rssi").text();
			SetSignalStrength(rssi, cellularSysNetworkMode, cellularDataConnMode);

			$(retXml).find("contextlist").each(function () {
				if ($(this).find("Item") && $(this).find("Item").length > 0) {
					var netStatus = false;
					$(this).find("Item").each(function (i) {
						var connetStatus = $(this).find("connection_status").text();
						if (0 == connetStatus) {
							SetPdpDisconnectIcon();
						} else if (1 == connetStatus) {
							netStatus = true;
							SetPdpConnectIcon();
						} else if (2 == connetStatus) {
							SetPdpDisconnectIcon();
							$("#imgGlobalConnArrow").attr("title", jQuery.i18n.prop("pdpConnStatus_connecting"));
						}
					});
				} else {
					SetPdpDisconnectIcon();
				}
			});
		}

		function GetConnectedDeviceInfo(type) {
			PostXmlAsync("statistics", "get_active_clients_num", null, function (retXml) {
				initConnectedDeviceInfo(retXml);
			}, type);

		}
		function initConnectedDeviceInfo(retXml) {
			if (g_wifi_switch_status == "on") {
				$("#imgWifiSwitchStatus").attr("src", "images/wifi.png");
				$("#lConnDeviceValue").show();
				var connDeviceNum = $(retXml).find("active_clients_num").text();
				var lan_clients_num = $(retXml).find("active_lan_clients_num").text();
				var usb_clients_num = $(retXml).find("active_usb_clients_num").text();
				var wifi_clients_num = connDeviceNum - lan_clients_num - usb_clients_num;
				wifi_clients_num = wifi_clients_num == "0" ? "" : wifi_clients_num;
				$("#lConnDeviceValue").html(wifi_clients_num);
			} else {
				$("#imgWifiSwitchStatus").attr("src", "images/wifi_off.png");
				$("#lConnDeviceValue").hide();
			}
		}

		function GetUnReadSms() {
			var smsMap = new Map();
			smsMap.put("RGW/sms_info/sms/type", 0);
			smsMap.put("RGW/sms_info/sms/read", 0);
			smsMap.put("RGW/sms_info/sms/location", 0);
			PostXmlAsync("sms", "sms.query", smsMap, function (retXml) {
				initUnReadSms(retXml);
			});
		}

		function initUnReadSms(retXml) {
			var unreadCount = $(retXml).find("count").text();
			if (unreadCount >= 1) {
				$("#unreadSMS").css("display", "inline-block");
				$("#unreadNum").text(unreadCount);

				var unReadIds = $(retXml).find("ids").text();
				var newArrs = unReadIds.split(",");
				var lastArrs = lastUnreadIds.split(",");
				var i, j;
				var newCount = 0;
				for (i = 0; i < newArrs.length; i++) {
					var found = false;
					for (j = 0; j < lastArrs.length; j++) {
						if (newArrs[i] == lastArrs[j]) {
							found = true;
							break;
						}
					}
					if (!found) {
						newCount++;
					}
				}
				lastUnreadIds = unReadIds;
				if (newCount > 0) {
					var MessAgeNotification = "";
					if (1 == newCount)
						MessAgeNotification = newCount + " " + jQuery.i18n.prop("lsmsOneNewArrivedSMS");
					else
						MessAgeNotification = newCount + " " + jQuery.i18n.prop("lsmsMoreNewArrivedSMS");
					showMsgBox(jQuery.i18n.prop("lsmsNotification"), MessAgeNotification);
				}

			} else {
				$("#unreadSMS").css("display", "none");
			}
		}

		function SetPdpConnectIcon() {
			$("#imgGlobalConnArrow").attr("title", jQuery.i18n.prop("pdpConnStatus_connected"));
			$("#imgGlobalConnArrow").attr("src", "images/con-arrow.png");
		}

		function SetPdpDisconnectIcon() {
			$("#imgGlobalConnArrow").attr("title", jQuery.i18n.prop("pdpConnStatus_disconnected"));
			$("#imgGlobalConnArrow").attr("src", "images/discon-arrow.png");
		}
		function SetSignalStrength(rssi, cellularSysNetworkMode, cellularDataConnMode) {
			if (0 == cellularSysNetworkMode) {
				document.getElementById("imgSignalStrength").src = "images/signal0.png";
			} else if (1 == cellularSysNetworkMode) { //GSM 2G3G
				if (cellularDataConnMode != 1 && cellularDataConnMode != 2 && cellularDataConnMode != 16) {
					//3G
					g_network_dashboard = '3G';
					if (rssi < 22)
						document.getElementById("imgSignalStrength").src = "images/signal0.png";
					else if (rssi < 27)
						document.getElementById("imgSignalStrength").src = "images/signal1.png";
					else if (rssi < 36)
						document.getElementById("imgSignalStrength").src = "images/signal2.png";
					else
						document.getElementById("imgSignalStrength").src = "images/signal3.png";
				} else {
					//2G
					g_network_dashboard = '2G';
					if (rssi < 6)
						document.getElementById("imgSignalStrength").src = "images/signal0.png";
					else if (rssi < 12)
						document.getElementById("imgSignalStrength").src = "images/signal1.png";
					else if (rssi < 24)
						document.getElementById("imgSignalStrength").src = "images/signal2.png";
					else
						document.getElementById("imgSignalStrength").src = "images/signal3.png";
				}
			} else if (2 == cellularSysNetworkMode) { //LTE
				g_network_dashboard = '4G';
				if (rssi <= 21) {
					document.getElementById("imgSignalStrength").src = "images/signal0.png";
				} else if (rssi <= 26)
					document.getElementById("imgSignalStrength").src = "images/signal1.png";
				else if (rssi < 31)
					document.getElementById("imgSignalStrength").src = "images/signal2.png";
				else
					document.getElementById("imgSignalStrength").src = "images/signal3.png";
			}
		}
	</script>
</head>

<body onload="initIndex()">
	<div id="ol"></div>
	<div id="mbox"><span>
			<div id="mbd"></div>
		</span></div>

	<div class="liginbox" id="divAdminApp" style="display:none;">
		<div style="z-index: -1;" class="liginbox1">

		</div>
		<br class="clear" />
		<div class="loginBox clearfloat">
			<div class="title">
				WELCOME TO
				<img src="images/logo.png" alt="" style="vertical-align: middle;margin-left:10px;">
			</div>
			<div style="position: relative;">
				<!-- <img src="images/smart_device.png" alt="" style="position: absolute;left: -184px;top: -18px;"> -->
			</div>
			<div class="left login_right">
				<input type='text' name='router_username' maxlength="32" value='' id='tbarouter_username'
					placeholder="Username" class='text_login' onchange='hideError()' />
				<br /><br />
				<input type='password' value='' id='tbarouter_password' maxlength="32" placeholder="Password"
					class="text_login" onchange='hideError()' onkeypress='checkEnter(event)' />
				<br /><br />
				<label class='error' id='lloginfailed' style='display: none'>Invalid username or password </label>
				<br>
				<input name="" type="button" class="button" id="btnLogIn" value="LOG IN" onclick='Login()' />
				<br /><br />
				<label id="last_login"></label>
			</div>
		</div>
	</div>
	<div class="fixRight">
		<span class="spanFont"> Manage your account easily and get the latest promos on</span> <a
			href="http://onelink.to/gigalifeapp" target="_blank"><img src="images/gigalife.png" alt=""></a>
	</div>
	<div id="confirmDlg" style="display: none">
		<div class='popUpBox2'>
			<h1 id="lt_confirmDlg_title" style="text-align: center;    padding: 10px;font-size: 20px;"></h1>
			<a href="#" id="confirmDlg_close" class="close" onclick="CloseDlg()">x</a>
			<div>
				<label id="lt_confirmDlg_msg" class="confirm_msg_label"></label>
				<br style="clear:both" />
				<div class="buttonRow1"
					style="border-top:1px solid #a7a7a7; padding:27px 0; margin:7px 0 0 0; text-align:center">
					<input id="lt_btnConfirmYes" type="button" class="btn-apply"
						style="font-size:16px;font-family: WonderUnitSans-Regular;" />
					<input id="lt_btnConfirmNo" type="button" onclick="CloseDlg()" class="btn-apply" />
				</div>
			</div>
		</div>
	</div>
</body>

</html>
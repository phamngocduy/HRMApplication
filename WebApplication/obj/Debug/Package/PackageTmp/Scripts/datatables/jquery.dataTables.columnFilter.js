



<!DOCTYPE html>
<html>
<head>
 <meta http-equiv="Content-Type" content="text/html; charset=UTF-8" >
 <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1" >
 
 <meta name="ROBOTS" content="NOARCHIVE">
 
 <link rel="icon" type="image/vnd.microsoft.icon" href="https://ssl.gstatic.com/codesite/ph/images/phosting.ico">
 
 
 <script type="text/javascript">
 
 
 
 
 var codesite_token = "daT9vRmcUgFdoZwQOykK5NHw6M4:1394866781053";
 
 
 var CS_env = {"profileUrl": "/u/108303546530773324054/", "token": "daT9vRmcUgFdoZwQOykK5NHw6M4:1394866781053", "domainName": null, "assetHostPath": "https://ssl.gstatic.com/codesite/ph", "assetVersionPath": "https://ssl.gstatic.com/codesite/ph/11512667522589661435", "projectHomeUrl": "/p/jquery-datatables-column-filter", "relativeBaseUrl": "", "projectName": "jquery-datatables-column-filter", "loggedInUserEmail": "nguyen.hpn@gmail.com"};
 var _gaq = _gaq || [];
 _gaq.push(
 ['siteTracker._setAccount', 'UA-18071-1'],
 ['siteTracker._trackPageview']);
 
 _gaq.push(
 ['projectTracker._setAccount', 'UA-17838786-4'],
 ['projectTracker._trackPageview']);
 
 (function() {
 var ga = document.createElement('script'); ga.type = 'text/javascript'; ga.async = true;
 ga.src = ('https:' == document.location.protocol ? 'https://ssl' : 'http://www') + '.google-analytics.com/ga.js';
 (document.getElementsByTagName('head')[0] || document.getElementsByTagName('body')[0]).appendChild(ga);
 })();
 
 </script>
 
 
 <title>jquery.dataTables.columnFilter.js - 
 jquery-datatables-column-filter -
 
 
 JQuery DataTables Column Filter plugin - Google Project Hosting
 </title>
 <link type="text/css" rel="stylesheet" href="https://ssl.gstatic.com/codesite/ph/11512667522589661435/css/core.css">
 
 <link type="text/css" rel="stylesheet" href="https://ssl.gstatic.com/codesite/ph/11512667522589661435/css/ph_detail.css" >
 
 
 <link type="text/css" rel="stylesheet" href="https://ssl.gstatic.com/codesite/ph/11512667522589661435/css/d_sb.css" >
 
 
 
<!--[if IE]>
 <link type="text/css" rel="stylesheet" href="https://ssl.gstatic.com/codesite/ph/11512667522589661435/css/d_ie.css" >
<![endif]-->
 <style type="text/css">
 .menuIcon.off { background: no-repeat url(https://ssl.gstatic.com/codesite/ph/images/dropdown_sprite.gif) 0 -42px }
 .menuIcon.on { background: no-repeat url(https://ssl.gstatic.com/codesite/ph/images/dropdown_sprite.gif) 0 -28px }
 .menuIcon.down { background: no-repeat url(https://ssl.gstatic.com/codesite/ph/images/dropdown_sprite.gif) 0 0; }
 
 
 
  tr.inline_comment {
 background: #fff;
 vertical-align: top;
 }
 div.draft, div.published {
 padding: .3em;
 border: 1px solid #999; 
 margin-bottom: .1em;
 font-family: arial, sans-serif;
 max-width: 60em;
 }
 div.draft {
 background: #ffa;
 } 
 div.published {
 background: #e5ecf9;
 }
 div.published .body, div.draft .body {
 padding: .5em .1em .1em .1em;
 max-width: 60em;
 white-space: pre-wrap;
 white-space: -moz-pre-wrap;
 white-space: -pre-wrap;
 white-space: -o-pre-wrap;
 word-wrap: break-word;
 font-size: 1em;
 }
 div.draft .actions {
 margin-left: 1em;
 font-size: 90%;
 }
 div.draft form {
 padding: .5em .5em .5em 0;
 }
 div.draft textarea, div.published textarea {
 width: 95%;
 height: 10em;
 font-family: arial, sans-serif;
 margin-bottom: .5em;
 }

 
 .nocursor, .nocursor td, .cursor_hidden, .cursor_hidden td {
 background-color: white;
 height: 2px;
 }
 .cursor, .cursor td {
 background-color: darkblue;
 height: 2px;
 display: '';
 }
 
 
.list {
 border: 1px solid white;
 border-bottom: 0;
}

 
 </style>
</head>
<body class="t4">
<script type="text/javascript">
 window.___gcfg = {lang: 'en'};
 (function() 
 {var po = document.createElement("script");
 po.type = "text/javascript"; po.async = true;po.src = "https://apis.google.com/js/plusone.js";
 var s = document.getElementsByTagName("script")[0];
 s.parentNode.insertBefore(po, s);
 })();
</script>
<div class="headbg">

 <div id="gaia">
 

 <span>
 
 
 
 <a href="#" id="multilogin-dropdown" onclick="return false;"
 ><u><b>nguyen.hpn@gmail.com</b></u> <small>&#9660;</small></a>
 
 
 | <a href="/u/108303546530773324054/" id="projects-dropdown" onclick="return false;"
 ><u>My favorites</u> <small>&#9660;</small></a>
 | <a href="/u/108303546530773324054/" onclick="_CS_click('/gb/ph/profile');"
 title="Profile, Updates, and Settings"
 ><u>Profile</u></a>
 | <a href="https://www.google.com/accounts/Logout?continue=https%3A%2F%2Fcode.google.com%2Fp%2Fjquery-datatables-column-filter%2Fsource%2Fbrowse%2Ftrunk%2Fmedia%2Fjs%2Fjquery.dataTables.columnFilter.js" 
 onclick="_CS_click('/gb/ph/signout');"
 ><u>Sign out</u></a>
 
 </span>

 </div>

 <div class="gbh" style="left: 0pt;"></div>
 <div class="gbh" style="right: 0pt;"></div>
 
 
 <div style="height: 1px"></div>
<!--[if lte IE 7]>
<div style="text-align:center;">
Your version of Internet Explorer is not supported. Try a browser that
contributes to open source, such as <a href="http://www.firefox.com">Firefox</a>,
<a href="http://www.google.com/chrome">Google Chrome</a>, or
<a href="http://code.google.com/chrome/chromeframe/">Google Chrome Frame</a>.
</div>
<![endif]-->



 <table style="padding:0px; margin: 0px 0px 10px 0px; width:100%" cellpadding="0" cellspacing="0"
 itemscope itemtype="http://schema.org/CreativeWork">
 <tr style="height: 58px;">
 
 
 
 <td id="plogo">
 <link itemprop="url" href="/p/jquery-datatables-column-filter">
 <a href="/p/jquery-datatables-column-filter/">
 
 <img src="https://ssl.gstatic.com/codesite/ph/images/defaultlogo.png" alt="Logo" itemprop="image">
 
 </a>
 </td>
 
 <td style="padding-left: 0.5em">
 
 <div id="pname">
 <a href="/p/jquery-datatables-column-filter/"><span itemprop="name">jquery-datatables-column-filter</span></a>
 </div>
 
 <div id="psum">
 <a id="project_summary_link"
 href="/p/jquery-datatables-column-filter/"><span itemprop="description">JQuery DataTables Column Filter plugin</span></a>
 
 </div>
 
 
 </td>
 <td style="white-space:nowrap;text-align:right; vertical-align:bottom;">
 
 <form action="/hosting/search">
 <input size="30" name="q" value="" type="text">
 
 <input type="submit" name="projectsearch" value="Search projects" >
 </form>
 
 </tr>
 </table>

</div>

 
<div id="mt" class="gtb"> 
 <a href="/p/jquery-datatables-column-filter/" class="tab ">Project&nbsp;Home</a>
 
 
 
 
 <a href="/p/jquery-datatables-column-filter/downloads/list" class="tab ">Downloads</a>
 
 
 
 
 
 <a href="/p/jquery-datatables-column-filter/w/list" class="tab ">Wiki</a>
 
 
 
 
 
 <a href="/p/jquery-datatables-column-filter/issues/list"
 class="tab ">Issues</a>
 
 
 
 
 
 <a href="/p/jquery-datatables-column-filter/source/checkout"
 class="tab active">Source</a>
 
 
 
 
 
 
 
 
 <div class=gtbc></div>
</div>
<table cellspacing="0" cellpadding="0" width="100%" align="center" border="0" class="st">
 <tr>
 
 
 
 
 
 
 <td class="subt">
 <div class="st2">
 <div class="isf">
 
 


 <span class="inst1"><a href="/p/jquery-datatables-column-filter/source/checkout">Checkout</a></span> &nbsp;
 <span class="inst2"><a href="/p/jquery-datatables-column-filter/source/browse/">Browse</a></span> &nbsp;
 <span class="inst3"><a href="/p/jquery-datatables-column-filter/source/list">Changes</a></span> &nbsp;
 
 
 
 
 
 
 
 </form>
 <script type="text/javascript">
 
 function codesearchQuery(form) {
 var query = document.getElementById('q').value;
 if (query) { form.action += '%20' + query; }
 }
 </script>
 </div>
</div>

 </td>
 
 
 
 <td align="right" valign="top" class="bevel-right"></td>
 </tr>
</table>


<script type="text/javascript">
 var cancelBubble = false;
 function _go(url) { document.location = url; }
</script>
<div id="maincol"
 
>

 




<div class="expand">
<div id="colcontrol">
<style type="text/css">
 #file_flipper { white-space: nowrap; padding-right: 2em; }
 #file_flipper.hidden { display: none; }
 #file_flipper .pagelink { color: #0000CC; text-decoration: underline; }
 #file_flipper #visiblefiles { padding-left: 0.5em; padding-right: 0.5em; }
</style>
<table id="nav_and_rev" class="list"
 cellpadding="0" cellspacing="0" width="100%">
 <tr>
 
 <td nowrap="nowrap" class="src_crumbs src_nav" width="33%">
 <strong class="src_nav">Source path:&nbsp;</strong>
 <span id="crumb_root">
 
 <a href="/p/jquery-datatables-column-filter/source/browse/">svn</a>/&nbsp;</span>
 <span id="crumb_links" class="ifClosed"><a href="/p/jquery-datatables-column-filter/source/browse/trunk/">trunk</a><span class="sp">/&nbsp;</span><a href="/p/jquery-datatables-column-filter/source/browse/trunk/media/">media</a><span class="sp">/&nbsp;</span><a href="/p/jquery-datatables-column-filter/source/browse/trunk/media/js/">js</a><span class="sp">/&nbsp;</span>jquery.dataTables.columnFilter.js</span>
 
 


 </td>
 
 
 <td nowrap="nowrap" width="33%" align="center">
 <a href="/p/jquery-datatables-column-filter/source/browse/trunk/media/js/jquery.dataTables.columnFilter.js?edit=1"
 ><img src="https://ssl.gstatic.com/codesite/ph/images/pencil-y14.png"
 class="edit_icon">Edit file</a>
 </td>
 
 
 <td nowrap="nowrap" width="33%" align="right">
 <table cellpadding="0" cellspacing="0" style="font-size: 100%"><tr>
 
 
 <td class="flipper">
 <ul class="leftside">
 
 <li><a href="/p/jquery-datatables-column-filter/source/browse/trunk/media/js/jquery.dataTables.columnFilter.js?r=81" title="Previous">&lsaquo;r81</a></li>
 
 </ul>
 </td>
 
 <td class="flipper"><b>r82</b></td>
 
 </tr></table>
 </td> 
 </tr>
</table>

<div class="fc">
 
 
 
<style type="text/css">
.undermouse span {
 background-image: url(https://ssl.gstatic.com/codesite/ph/images/comments.gif); }
</style>
<table class="opened" id="review_comment_area"
><tr>
<td id="nums">
<pre><table width="100%"><tr class="nocursor"><td></td></tr></table></pre>
<pre><table width="100%" id="nums_table_0"><tr id="gr_svn82_1"

><td id="1"><a href="#1">1</a></td></tr
><tr id="gr_svn82_2"

><td id="2"><a href="#2">2</a></td></tr
><tr id="gr_svn82_3"

><td id="3"><a href="#3">3</a></td></tr
><tr id="gr_svn82_4"

><td id="4"><a href="#4">4</a></td></tr
><tr id="gr_svn82_5"

><td id="5"><a href="#5">5</a></td></tr
><tr id="gr_svn82_6"

><td id="6"><a href="#6">6</a></td></tr
><tr id="gr_svn82_7"

><td id="7"><a href="#7">7</a></td></tr
><tr id="gr_svn82_8"

><td id="8"><a href="#8">8</a></td></tr
><tr id="gr_svn82_9"

><td id="9"><a href="#9">9</a></td></tr
><tr id="gr_svn82_10"

><td id="10"><a href="#10">10</a></td></tr
><tr id="gr_svn82_11"

><td id="11"><a href="#11">11</a></td></tr
><tr id="gr_svn82_12"

><td id="12"><a href="#12">12</a></td></tr
><tr id="gr_svn82_13"

><td id="13"><a href="#13">13</a></td></tr
><tr id="gr_svn82_14"

><td id="14"><a href="#14">14</a></td></tr
><tr id="gr_svn82_15"

><td id="15"><a href="#15">15</a></td></tr
><tr id="gr_svn82_16"

><td id="16"><a href="#16">16</a></td></tr
><tr id="gr_svn82_17"

><td id="17"><a href="#17">17</a></td></tr
><tr id="gr_svn82_18"

><td id="18"><a href="#18">18</a></td></tr
><tr id="gr_svn82_19"

><td id="19"><a href="#19">19</a></td></tr
><tr id="gr_svn82_20"

><td id="20"><a href="#20">20</a></td></tr
><tr id="gr_svn82_21"

><td id="21"><a href="#21">21</a></td></tr
><tr id="gr_svn82_22"

><td id="22"><a href="#22">22</a></td></tr
><tr id="gr_svn82_23"

><td id="23"><a href="#23">23</a></td></tr
><tr id="gr_svn82_24"

><td id="24"><a href="#24">24</a></td></tr
><tr id="gr_svn82_25"

><td id="25"><a href="#25">25</a></td></tr
><tr id="gr_svn82_26"

><td id="26"><a href="#26">26</a></td></tr
><tr id="gr_svn82_27"

><td id="27"><a href="#27">27</a></td></tr
><tr id="gr_svn82_28"

><td id="28"><a href="#28">28</a></td></tr
><tr id="gr_svn82_29"

><td id="29"><a href="#29">29</a></td></tr
><tr id="gr_svn82_30"

><td id="30"><a href="#30">30</a></td></tr
><tr id="gr_svn82_31"

><td id="31"><a href="#31">31</a></td></tr
><tr id="gr_svn82_32"

><td id="32"><a href="#32">32</a></td></tr
><tr id="gr_svn82_33"

><td id="33"><a href="#33">33</a></td></tr
><tr id="gr_svn82_34"

><td id="34"><a href="#34">34</a></td></tr
><tr id="gr_svn82_35"

><td id="35"><a href="#35">35</a></td></tr
><tr id="gr_svn82_36"

><td id="36"><a href="#36">36</a></td></tr
><tr id="gr_svn82_37"

><td id="37"><a href="#37">37</a></td></tr
><tr id="gr_svn82_38"

><td id="38"><a href="#38">38</a></td></tr
><tr id="gr_svn82_39"

><td id="39"><a href="#39">39</a></td></tr
><tr id="gr_svn82_40"

><td id="40"><a href="#40">40</a></td></tr
><tr id="gr_svn82_41"

><td id="41"><a href="#41">41</a></td></tr
><tr id="gr_svn82_42"

><td id="42"><a href="#42">42</a></td></tr
><tr id="gr_svn82_43"

><td id="43"><a href="#43">43</a></td></tr
><tr id="gr_svn82_44"

><td id="44"><a href="#44">44</a></td></tr
><tr id="gr_svn82_45"

><td id="45"><a href="#45">45</a></td></tr
><tr id="gr_svn82_46"

><td id="46"><a href="#46">46</a></td></tr
><tr id="gr_svn82_47"

><td id="47"><a href="#47">47</a></td></tr
><tr id="gr_svn82_48"

><td id="48"><a href="#48">48</a></td></tr
><tr id="gr_svn82_49"

><td id="49"><a href="#49">49</a></td></tr
><tr id="gr_svn82_50"

><td id="50"><a href="#50">50</a></td></tr
><tr id="gr_svn82_51"

><td id="51"><a href="#51">51</a></td></tr
><tr id="gr_svn82_52"

><td id="52"><a href="#52">52</a></td></tr
><tr id="gr_svn82_53"

><td id="53"><a href="#53">53</a></td></tr
><tr id="gr_svn82_54"

><td id="54"><a href="#54">54</a></td></tr
><tr id="gr_svn82_55"

><td id="55"><a href="#55">55</a></td></tr
><tr id="gr_svn82_56"

><td id="56"><a href="#56">56</a></td></tr
><tr id="gr_svn82_57"

><td id="57"><a href="#57">57</a></td></tr
><tr id="gr_svn82_58"

><td id="58"><a href="#58">58</a></td></tr
><tr id="gr_svn82_59"

><td id="59"><a href="#59">59</a></td></tr
><tr id="gr_svn82_60"

><td id="60"><a href="#60">60</a></td></tr
><tr id="gr_svn82_61"

><td id="61"><a href="#61">61</a></td></tr
><tr id="gr_svn82_62"

><td id="62"><a href="#62">62</a></td></tr
><tr id="gr_svn82_63"

><td id="63"><a href="#63">63</a></td></tr
><tr id="gr_svn82_64"

><td id="64"><a href="#64">64</a></td></tr
><tr id="gr_svn82_65"

><td id="65"><a href="#65">65</a></td></tr
><tr id="gr_svn82_66"

><td id="66"><a href="#66">66</a></td></tr
><tr id="gr_svn82_67"

><td id="67"><a href="#67">67</a></td></tr
><tr id="gr_svn82_68"

><td id="68"><a href="#68">68</a></td></tr
><tr id="gr_svn82_69"

><td id="69"><a href="#69">69</a></td></tr
><tr id="gr_svn82_70"

><td id="70"><a href="#70">70</a></td></tr
><tr id="gr_svn82_71"

><td id="71"><a href="#71">71</a></td></tr
><tr id="gr_svn82_72"

><td id="72"><a href="#72">72</a></td></tr
><tr id="gr_svn82_73"

><td id="73"><a href="#73">73</a></td></tr
><tr id="gr_svn82_74"

><td id="74"><a href="#74">74</a></td></tr
><tr id="gr_svn82_75"

><td id="75"><a href="#75">75</a></td></tr
><tr id="gr_svn82_76"

><td id="76"><a href="#76">76</a></td></tr
><tr id="gr_svn82_77"

><td id="77"><a href="#77">77</a></td></tr
><tr id="gr_svn82_78"

><td id="78"><a href="#78">78</a></td></tr
><tr id="gr_svn82_79"

><td id="79"><a href="#79">79</a></td></tr
><tr id="gr_svn82_80"

><td id="80"><a href="#80">80</a></td></tr
><tr id="gr_svn82_81"

><td id="81"><a href="#81">81</a></td></tr
><tr id="gr_svn82_82"

><td id="82"><a href="#82">82</a></td></tr
><tr id="gr_svn82_83"

><td id="83"><a href="#83">83</a></td></tr
><tr id="gr_svn82_84"

><td id="84"><a href="#84">84</a></td></tr
><tr id="gr_svn82_85"

><td id="85"><a href="#85">85</a></td></tr
><tr id="gr_svn82_86"

><td id="86"><a href="#86">86</a></td></tr
><tr id="gr_svn82_87"

><td id="87"><a href="#87">87</a></td></tr
><tr id="gr_svn82_88"

><td id="88"><a href="#88">88</a></td></tr
><tr id="gr_svn82_89"

><td id="89"><a href="#89">89</a></td></tr
><tr id="gr_svn82_90"

><td id="90"><a href="#90">90</a></td></tr
><tr id="gr_svn82_91"

><td id="91"><a href="#91">91</a></td></tr
><tr id="gr_svn82_92"

><td id="92"><a href="#92">92</a></td></tr
><tr id="gr_svn82_93"

><td id="93"><a href="#93">93</a></td></tr
><tr id="gr_svn82_94"

><td id="94"><a href="#94">94</a></td></tr
><tr id="gr_svn82_95"

><td id="95"><a href="#95">95</a></td></tr
><tr id="gr_svn82_96"

><td id="96"><a href="#96">96</a></td></tr
><tr id="gr_svn82_97"

><td id="97"><a href="#97">97</a></td></tr
><tr id="gr_svn82_98"

><td id="98"><a href="#98">98</a></td></tr
><tr id="gr_svn82_99"

><td id="99"><a href="#99">99</a></td></tr
><tr id="gr_svn82_100"

><td id="100"><a href="#100">100</a></td></tr
><tr id="gr_svn82_101"

><td id="101"><a href="#101">101</a></td></tr
><tr id="gr_svn82_102"

><td id="102"><a href="#102">102</a></td></tr
><tr id="gr_svn82_103"

><td id="103"><a href="#103">103</a></td></tr
><tr id="gr_svn82_104"

><td id="104"><a href="#104">104</a></td></tr
><tr id="gr_svn82_105"

><td id="105"><a href="#105">105</a></td></tr
><tr id="gr_svn82_106"

><td id="106"><a href="#106">106</a></td></tr
><tr id="gr_svn82_107"

><td id="107"><a href="#107">107</a></td></tr
><tr id="gr_svn82_108"

><td id="108"><a href="#108">108</a></td></tr
><tr id="gr_svn82_109"

><td id="109"><a href="#109">109</a></td></tr
><tr id="gr_svn82_110"

><td id="110"><a href="#110">110</a></td></tr
><tr id="gr_svn82_111"

><td id="111"><a href="#111">111</a></td></tr
><tr id="gr_svn82_112"

><td id="112"><a href="#112">112</a></td></tr
><tr id="gr_svn82_113"

><td id="113"><a href="#113">113</a></td></tr
><tr id="gr_svn82_114"

><td id="114"><a href="#114">114</a></td></tr
><tr id="gr_svn82_115"

><td id="115"><a href="#115">115</a></td></tr
><tr id="gr_svn82_116"

><td id="116"><a href="#116">116</a></td></tr
><tr id="gr_svn82_117"

><td id="117"><a href="#117">117</a></td></tr
><tr id="gr_svn82_118"

><td id="118"><a href="#118">118</a></td></tr
><tr id="gr_svn82_119"

><td id="119"><a href="#119">119</a></td></tr
><tr id="gr_svn82_120"

><td id="120"><a href="#120">120</a></td></tr
><tr id="gr_svn82_121"

><td id="121"><a href="#121">121</a></td></tr
><tr id="gr_svn82_122"

><td id="122"><a href="#122">122</a></td></tr
><tr id="gr_svn82_123"

><td id="123"><a href="#123">123</a></td></tr
><tr id="gr_svn82_124"

><td id="124"><a href="#124">124</a></td></tr
><tr id="gr_svn82_125"

><td id="125"><a href="#125">125</a></td></tr
><tr id="gr_svn82_126"

><td id="126"><a href="#126">126</a></td></tr
><tr id="gr_svn82_127"

><td id="127"><a href="#127">127</a></td></tr
><tr id="gr_svn82_128"

><td id="128"><a href="#128">128</a></td></tr
><tr id="gr_svn82_129"

><td id="129"><a href="#129">129</a></td></tr
><tr id="gr_svn82_130"

><td id="130"><a href="#130">130</a></td></tr
><tr id="gr_svn82_131"

><td id="131"><a href="#131">131</a></td></tr
><tr id="gr_svn82_132"

><td id="132"><a href="#132">132</a></td></tr
><tr id="gr_svn82_133"

><td id="133"><a href="#133">133</a></td></tr
><tr id="gr_svn82_134"

><td id="134"><a href="#134">134</a></td></tr
><tr id="gr_svn82_135"

><td id="135"><a href="#135">135</a></td></tr
><tr id="gr_svn82_136"

><td id="136"><a href="#136">136</a></td></tr
><tr id="gr_svn82_137"

><td id="137"><a href="#137">137</a></td></tr
><tr id="gr_svn82_138"

><td id="138"><a href="#138">138</a></td></tr
><tr id="gr_svn82_139"

><td id="139"><a href="#139">139</a></td></tr
><tr id="gr_svn82_140"

><td id="140"><a href="#140">140</a></td></tr
><tr id="gr_svn82_141"

><td id="141"><a href="#141">141</a></td></tr
><tr id="gr_svn82_142"

><td id="142"><a href="#142">142</a></td></tr
><tr id="gr_svn82_143"

><td id="143"><a href="#143">143</a></td></tr
><tr id="gr_svn82_144"

><td id="144"><a href="#144">144</a></td></tr
><tr id="gr_svn82_145"

><td id="145"><a href="#145">145</a></td></tr
><tr id="gr_svn82_146"

><td id="146"><a href="#146">146</a></td></tr
><tr id="gr_svn82_147"

><td id="147"><a href="#147">147</a></td></tr
><tr id="gr_svn82_148"

><td id="148"><a href="#148">148</a></td></tr
><tr id="gr_svn82_149"

><td id="149"><a href="#149">149</a></td></tr
><tr id="gr_svn82_150"

><td id="150"><a href="#150">150</a></td></tr
><tr id="gr_svn82_151"

><td id="151"><a href="#151">151</a></td></tr
><tr id="gr_svn82_152"

><td id="152"><a href="#152">152</a></td></tr
><tr id="gr_svn82_153"

><td id="153"><a href="#153">153</a></td></tr
><tr id="gr_svn82_154"

><td id="154"><a href="#154">154</a></td></tr
><tr id="gr_svn82_155"

><td id="155"><a href="#155">155</a></td></tr
><tr id="gr_svn82_156"

><td id="156"><a href="#156">156</a></td></tr
><tr id="gr_svn82_157"

><td id="157"><a href="#157">157</a></td></tr
><tr id="gr_svn82_158"

><td id="158"><a href="#158">158</a></td></tr
><tr id="gr_svn82_159"

><td id="159"><a href="#159">159</a></td></tr
><tr id="gr_svn82_160"

><td id="160"><a href="#160">160</a></td></tr
><tr id="gr_svn82_161"

><td id="161"><a href="#161">161</a></td></tr
><tr id="gr_svn82_162"

><td id="162"><a href="#162">162</a></td></tr
><tr id="gr_svn82_163"

><td id="163"><a href="#163">163</a></td></tr
><tr id="gr_svn82_164"

><td id="164"><a href="#164">164</a></td></tr
><tr id="gr_svn82_165"

><td id="165"><a href="#165">165</a></td></tr
><tr id="gr_svn82_166"

><td id="166"><a href="#166">166</a></td></tr
><tr id="gr_svn82_167"

><td id="167"><a href="#167">167</a></td></tr
><tr id="gr_svn82_168"

><td id="168"><a href="#168">168</a></td></tr
><tr id="gr_svn82_169"

><td id="169"><a href="#169">169</a></td></tr
><tr id="gr_svn82_170"

><td id="170"><a href="#170">170</a></td></tr
><tr id="gr_svn82_171"

><td id="171"><a href="#171">171</a></td></tr
><tr id="gr_svn82_172"

><td id="172"><a href="#172">172</a></td></tr
><tr id="gr_svn82_173"

><td id="173"><a href="#173">173</a></td></tr
><tr id="gr_svn82_174"

><td id="174"><a href="#174">174</a></td></tr
><tr id="gr_svn82_175"

><td id="175"><a href="#175">175</a></td></tr
><tr id="gr_svn82_176"

><td id="176"><a href="#176">176</a></td></tr
><tr id="gr_svn82_177"

><td id="177"><a href="#177">177</a></td></tr
><tr id="gr_svn82_178"

><td id="178"><a href="#178">178</a></td></tr
><tr id="gr_svn82_179"

><td id="179"><a href="#179">179</a></td></tr
><tr id="gr_svn82_180"

><td id="180"><a href="#180">180</a></td></tr
><tr id="gr_svn82_181"

><td id="181"><a href="#181">181</a></td></tr
><tr id="gr_svn82_182"

><td id="182"><a href="#182">182</a></td></tr
><tr id="gr_svn82_183"

><td id="183"><a href="#183">183</a></td></tr
><tr id="gr_svn82_184"

><td id="184"><a href="#184">184</a></td></tr
><tr id="gr_svn82_185"

><td id="185"><a href="#185">185</a></td></tr
><tr id="gr_svn82_186"

><td id="186"><a href="#186">186</a></td></tr
><tr id="gr_svn82_187"

><td id="187"><a href="#187">187</a></td></tr
><tr id="gr_svn82_188"

><td id="188"><a href="#188">188</a></td></tr
><tr id="gr_svn82_189"

><td id="189"><a href="#189">189</a></td></tr
><tr id="gr_svn82_190"

><td id="190"><a href="#190">190</a></td></tr
><tr id="gr_svn82_191"

><td id="191"><a href="#191">191</a></td></tr
><tr id="gr_svn82_192"

><td id="192"><a href="#192">192</a></td></tr
><tr id="gr_svn82_193"

><td id="193"><a href="#193">193</a></td></tr
><tr id="gr_svn82_194"

><td id="194"><a href="#194">194</a></td></tr
><tr id="gr_svn82_195"

><td id="195"><a href="#195">195</a></td></tr
><tr id="gr_svn82_196"

><td id="196"><a href="#196">196</a></td></tr
><tr id="gr_svn82_197"

><td id="197"><a href="#197">197</a></td></tr
><tr id="gr_svn82_198"

><td id="198"><a href="#198">198</a></td></tr
><tr id="gr_svn82_199"

><td id="199"><a href="#199">199</a></td></tr
><tr id="gr_svn82_200"

><td id="200"><a href="#200">200</a></td></tr
><tr id="gr_svn82_201"

><td id="201"><a href="#201">201</a></td></tr
><tr id="gr_svn82_202"

><td id="202"><a href="#202">202</a></td></tr
><tr id="gr_svn82_203"

><td id="203"><a href="#203">203</a></td></tr
><tr id="gr_svn82_204"

><td id="204"><a href="#204">204</a></td></tr
><tr id="gr_svn82_205"

><td id="205"><a href="#205">205</a></td></tr
><tr id="gr_svn82_206"

><td id="206"><a href="#206">206</a></td></tr
><tr id="gr_svn82_207"

><td id="207"><a href="#207">207</a></td></tr
><tr id="gr_svn82_208"

><td id="208"><a href="#208">208</a></td></tr
><tr id="gr_svn82_209"

><td id="209"><a href="#209">209</a></td></tr
><tr id="gr_svn82_210"

><td id="210"><a href="#210">210</a></td></tr
><tr id="gr_svn82_211"

><td id="211"><a href="#211">211</a></td></tr
><tr id="gr_svn82_212"

><td id="212"><a href="#212">212</a></td></tr
><tr id="gr_svn82_213"

><td id="213"><a href="#213">213</a></td></tr
><tr id="gr_svn82_214"

><td id="214"><a href="#214">214</a></td></tr
><tr id="gr_svn82_215"

><td id="215"><a href="#215">215</a></td></tr
><tr id="gr_svn82_216"

><td id="216"><a href="#216">216</a></td></tr
><tr id="gr_svn82_217"

><td id="217"><a href="#217">217</a></td></tr
><tr id="gr_svn82_218"

><td id="218"><a href="#218">218</a></td></tr
><tr id="gr_svn82_219"

><td id="219"><a href="#219">219</a></td></tr
><tr id="gr_svn82_220"

><td id="220"><a href="#220">220</a></td></tr
><tr id="gr_svn82_221"

><td id="221"><a href="#221">221</a></td></tr
><tr id="gr_svn82_222"

><td id="222"><a href="#222">222</a></td></tr
><tr id="gr_svn82_223"

><td id="223"><a href="#223">223</a></td></tr
><tr id="gr_svn82_224"

><td id="224"><a href="#224">224</a></td></tr
><tr id="gr_svn82_225"

><td id="225"><a href="#225">225</a></td></tr
><tr id="gr_svn82_226"

><td id="226"><a href="#226">226</a></td></tr
><tr id="gr_svn82_227"

><td id="227"><a href="#227">227</a></td></tr
><tr id="gr_svn82_228"

><td id="228"><a href="#228">228</a></td></tr
><tr id="gr_svn82_229"

><td id="229"><a href="#229">229</a></td></tr
><tr id="gr_svn82_230"

><td id="230"><a href="#230">230</a></td></tr
><tr id="gr_svn82_231"

><td id="231"><a href="#231">231</a></td></tr
><tr id="gr_svn82_232"

><td id="232"><a href="#232">232</a></td></tr
><tr id="gr_svn82_233"

><td id="233"><a href="#233">233</a></td></tr
><tr id="gr_svn82_234"

><td id="234"><a href="#234">234</a></td></tr
><tr id="gr_svn82_235"

><td id="235"><a href="#235">235</a></td></tr
><tr id="gr_svn82_236"

><td id="236"><a href="#236">236</a></td></tr
><tr id="gr_svn82_237"

><td id="237"><a href="#237">237</a></td></tr
><tr id="gr_svn82_238"

><td id="238"><a href="#238">238</a></td></tr
><tr id="gr_svn82_239"

><td id="239"><a href="#239">239</a></td></tr
><tr id="gr_svn82_240"

><td id="240"><a href="#240">240</a></td></tr
><tr id="gr_svn82_241"

><td id="241"><a href="#241">241</a></td></tr
><tr id="gr_svn82_242"

><td id="242"><a href="#242">242</a></td></tr
><tr id="gr_svn82_243"

><td id="243"><a href="#243">243</a></td></tr
><tr id="gr_svn82_244"

><td id="244"><a href="#244">244</a></td></tr
><tr id="gr_svn82_245"

><td id="245"><a href="#245">245</a></td></tr
><tr id="gr_svn82_246"

><td id="246"><a href="#246">246</a></td></tr
><tr id="gr_svn82_247"

><td id="247"><a href="#247">247</a></td></tr
><tr id="gr_svn82_248"

><td id="248"><a href="#248">248</a></td></tr
><tr id="gr_svn82_249"

><td id="249"><a href="#249">249</a></td></tr
><tr id="gr_svn82_250"

><td id="250"><a href="#250">250</a></td></tr
><tr id="gr_svn82_251"

><td id="251"><a href="#251">251</a></td></tr
><tr id="gr_svn82_252"

><td id="252"><a href="#252">252</a></td></tr
><tr id="gr_svn82_253"

><td id="253"><a href="#253">253</a></td></tr
><tr id="gr_svn82_254"

><td id="254"><a href="#254">254</a></td></tr
><tr id="gr_svn82_255"

><td id="255"><a href="#255">255</a></td></tr
><tr id="gr_svn82_256"

><td id="256"><a href="#256">256</a></td></tr
><tr id="gr_svn82_257"

><td id="257"><a href="#257">257</a></td></tr
><tr id="gr_svn82_258"

><td id="258"><a href="#258">258</a></td></tr
><tr id="gr_svn82_259"

><td id="259"><a href="#259">259</a></td></tr
><tr id="gr_svn82_260"

><td id="260"><a href="#260">260</a></td></tr
><tr id="gr_svn82_261"

><td id="261"><a href="#261">261</a></td></tr
><tr id="gr_svn82_262"

><td id="262"><a href="#262">262</a></td></tr
><tr id="gr_svn82_263"

><td id="263"><a href="#263">263</a></td></tr
><tr id="gr_svn82_264"

><td id="264"><a href="#264">264</a></td></tr
><tr id="gr_svn82_265"

><td id="265"><a href="#265">265</a></td></tr
><tr id="gr_svn82_266"

><td id="266"><a href="#266">266</a></td></tr
><tr id="gr_svn82_267"

><td id="267"><a href="#267">267</a></td></tr
><tr id="gr_svn82_268"

><td id="268"><a href="#268">268</a></td></tr
><tr id="gr_svn82_269"

><td id="269"><a href="#269">269</a></td></tr
><tr id="gr_svn82_270"

><td id="270"><a href="#270">270</a></td></tr
><tr id="gr_svn82_271"

><td id="271"><a href="#271">271</a></td></tr
><tr id="gr_svn82_272"

><td id="272"><a href="#272">272</a></td></tr
><tr id="gr_svn82_273"

><td id="273"><a href="#273">273</a></td></tr
><tr id="gr_svn82_274"

><td id="274"><a href="#274">274</a></td></tr
><tr id="gr_svn82_275"

><td id="275"><a href="#275">275</a></td></tr
><tr id="gr_svn82_276"

><td id="276"><a href="#276">276</a></td></tr
><tr id="gr_svn82_277"

><td id="277"><a href="#277">277</a></td></tr
><tr id="gr_svn82_278"

><td id="278"><a href="#278">278</a></td></tr
><tr id="gr_svn82_279"

><td id="279"><a href="#279">279</a></td></tr
><tr id="gr_svn82_280"

><td id="280"><a href="#280">280</a></td></tr
><tr id="gr_svn82_281"

><td id="281"><a href="#281">281</a></td></tr
><tr id="gr_svn82_282"

><td id="282"><a href="#282">282</a></td></tr
><tr id="gr_svn82_283"

><td id="283"><a href="#283">283</a></td></tr
><tr id="gr_svn82_284"

><td id="284"><a href="#284">284</a></td></tr
><tr id="gr_svn82_285"

><td id="285"><a href="#285">285</a></td></tr
><tr id="gr_svn82_286"

><td id="286"><a href="#286">286</a></td></tr
><tr id="gr_svn82_287"

><td id="287"><a href="#287">287</a></td></tr
><tr id="gr_svn82_288"

><td id="288"><a href="#288">288</a></td></tr
><tr id="gr_svn82_289"

><td id="289"><a href="#289">289</a></td></tr
><tr id="gr_svn82_290"

><td id="290"><a href="#290">290</a></td></tr
><tr id="gr_svn82_291"

><td id="291"><a href="#291">291</a></td></tr
><tr id="gr_svn82_292"

><td id="292"><a href="#292">292</a></td></tr
><tr id="gr_svn82_293"

><td id="293"><a href="#293">293</a></td></tr
><tr id="gr_svn82_294"

><td id="294"><a href="#294">294</a></td></tr
><tr id="gr_svn82_295"

><td id="295"><a href="#295">295</a></td></tr
><tr id="gr_svn82_296"

><td id="296"><a href="#296">296</a></td></tr
><tr id="gr_svn82_297"

><td id="297"><a href="#297">297</a></td></tr
><tr id="gr_svn82_298"

><td id="298"><a href="#298">298</a></td></tr
><tr id="gr_svn82_299"

><td id="299"><a href="#299">299</a></td></tr
><tr id="gr_svn82_300"

><td id="300"><a href="#300">300</a></td></tr
><tr id="gr_svn82_301"

><td id="301"><a href="#301">301</a></td></tr
><tr id="gr_svn82_302"

><td id="302"><a href="#302">302</a></td></tr
><tr id="gr_svn82_303"

><td id="303"><a href="#303">303</a></td></tr
><tr id="gr_svn82_304"

><td id="304"><a href="#304">304</a></td></tr
><tr id="gr_svn82_305"

><td id="305"><a href="#305">305</a></td></tr
><tr id="gr_svn82_306"

><td id="306"><a href="#306">306</a></td></tr
><tr id="gr_svn82_307"

><td id="307"><a href="#307">307</a></td></tr
><tr id="gr_svn82_308"

><td id="308"><a href="#308">308</a></td></tr
><tr id="gr_svn82_309"

><td id="309"><a href="#309">309</a></td></tr
><tr id="gr_svn82_310"

><td id="310"><a href="#310">310</a></td></tr
><tr id="gr_svn82_311"

><td id="311"><a href="#311">311</a></td></tr
><tr id="gr_svn82_312"

><td id="312"><a href="#312">312</a></td></tr
><tr id="gr_svn82_313"

><td id="313"><a href="#313">313</a></td></tr
><tr id="gr_svn82_314"

><td id="314"><a href="#314">314</a></td></tr
><tr id="gr_svn82_315"

><td id="315"><a href="#315">315</a></td></tr
><tr id="gr_svn82_316"

><td id="316"><a href="#316">316</a></td></tr
><tr id="gr_svn82_317"

><td id="317"><a href="#317">317</a></td></tr
><tr id="gr_svn82_318"

><td id="318"><a href="#318">318</a></td></tr
><tr id="gr_svn82_319"

><td id="319"><a href="#319">319</a></td></tr
><tr id="gr_svn82_320"

><td id="320"><a href="#320">320</a></td></tr
><tr id="gr_svn82_321"

><td id="321"><a href="#321">321</a></td></tr
><tr id="gr_svn82_322"

><td id="322"><a href="#322">322</a></td></tr
><tr id="gr_svn82_323"

><td id="323"><a href="#323">323</a></td></tr
><tr id="gr_svn82_324"

><td id="324"><a href="#324">324</a></td></tr
><tr id="gr_svn82_325"

><td id="325"><a href="#325">325</a></td></tr
><tr id="gr_svn82_326"

><td id="326"><a href="#326">326</a></td></tr
><tr id="gr_svn82_327"

><td id="327"><a href="#327">327</a></td></tr
><tr id="gr_svn82_328"

><td id="328"><a href="#328">328</a></td></tr
><tr id="gr_svn82_329"

><td id="329"><a href="#329">329</a></td></tr
><tr id="gr_svn82_330"

><td id="330"><a href="#330">330</a></td></tr
><tr id="gr_svn82_331"

><td id="331"><a href="#331">331</a></td></tr
><tr id="gr_svn82_332"

><td id="332"><a href="#332">332</a></td></tr
><tr id="gr_svn82_333"

><td id="333"><a href="#333">333</a></td></tr
><tr id="gr_svn82_334"

><td id="334"><a href="#334">334</a></td></tr
><tr id="gr_svn82_335"

><td id="335"><a href="#335">335</a></td></tr
><tr id="gr_svn82_336"

><td id="336"><a href="#336">336</a></td></tr
><tr id="gr_svn82_337"

><td id="337"><a href="#337">337</a></td></tr
><tr id="gr_svn82_338"

><td id="338"><a href="#338">338</a></td></tr
><tr id="gr_svn82_339"

><td id="339"><a href="#339">339</a></td></tr
><tr id="gr_svn82_340"

><td id="340"><a href="#340">340</a></td></tr
><tr id="gr_svn82_341"

><td id="341"><a href="#341">341</a></td></tr
><tr id="gr_svn82_342"

><td id="342"><a href="#342">342</a></td></tr
><tr id="gr_svn82_343"

><td id="343"><a href="#343">343</a></td></tr
><tr id="gr_svn82_344"

><td id="344"><a href="#344">344</a></td></tr
><tr id="gr_svn82_345"

><td id="345"><a href="#345">345</a></td></tr
><tr id="gr_svn82_346"

><td id="346"><a href="#346">346</a></td></tr
><tr id="gr_svn82_347"

><td id="347"><a href="#347">347</a></td></tr
><tr id="gr_svn82_348"

><td id="348"><a href="#348">348</a></td></tr
><tr id="gr_svn82_349"

><td id="349"><a href="#349">349</a></td></tr
><tr id="gr_svn82_350"

><td id="350"><a href="#350">350</a></td></tr
><tr id="gr_svn82_351"

><td id="351"><a href="#351">351</a></td></tr
><tr id="gr_svn82_352"

><td id="352"><a href="#352">352</a></td></tr
><tr id="gr_svn82_353"

><td id="353"><a href="#353">353</a></td></tr
><tr id="gr_svn82_354"

><td id="354"><a href="#354">354</a></td></tr
><tr id="gr_svn82_355"

><td id="355"><a href="#355">355</a></td></tr
><tr id="gr_svn82_356"

><td id="356"><a href="#356">356</a></td></tr
><tr id="gr_svn82_357"

><td id="357"><a href="#357">357</a></td></tr
><tr id="gr_svn82_358"

><td id="358"><a href="#358">358</a></td></tr
><tr id="gr_svn82_359"

><td id="359"><a href="#359">359</a></td></tr
><tr id="gr_svn82_360"

><td id="360"><a href="#360">360</a></td></tr
><tr id="gr_svn82_361"

><td id="361"><a href="#361">361</a></td></tr
><tr id="gr_svn82_362"

><td id="362"><a href="#362">362</a></td></tr
><tr id="gr_svn82_363"

><td id="363"><a href="#363">363</a></td></tr
><tr id="gr_svn82_364"

><td id="364"><a href="#364">364</a></td></tr
><tr id="gr_svn82_365"

><td id="365"><a href="#365">365</a></td></tr
><tr id="gr_svn82_366"

><td id="366"><a href="#366">366</a></td></tr
><tr id="gr_svn82_367"

><td id="367"><a href="#367">367</a></td></tr
><tr id="gr_svn82_368"

><td id="368"><a href="#368">368</a></td></tr
><tr id="gr_svn82_369"

><td id="369"><a href="#369">369</a></td></tr
><tr id="gr_svn82_370"

><td id="370"><a href="#370">370</a></td></tr
><tr id="gr_svn82_371"

><td id="371"><a href="#371">371</a></td></tr
><tr id="gr_svn82_372"

><td id="372"><a href="#372">372</a></td></tr
><tr id="gr_svn82_373"

><td id="373"><a href="#373">373</a></td></tr
><tr id="gr_svn82_374"

><td id="374"><a href="#374">374</a></td></tr
><tr id="gr_svn82_375"

><td id="375"><a href="#375">375</a></td></tr
><tr id="gr_svn82_376"

><td id="376"><a href="#376">376</a></td></tr
><tr id="gr_svn82_377"

><td id="377"><a href="#377">377</a></td></tr
><tr id="gr_svn82_378"

><td id="378"><a href="#378">378</a></td></tr
><tr id="gr_svn82_379"

><td id="379"><a href="#379">379</a></td></tr
><tr id="gr_svn82_380"

><td id="380"><a href="#380">380</a></td></tr
><tr id="gr_svn82_381"

><td id="381"><a href="#381">381</a></td></tr
><tr id="gr_svn82_382"

><td id="382"><a href="#382">382</a></td></tr
><tr id="gr_svn82_383"

><td id="383"><a href="#383">383</a></td></tr
><tr id="gr_svn82_384"

><td id="384"><a href="#384">384</a></td></tr
><tr id="gr_svn82_385"

><td id="385"><a href="#385">385</a></td></tr
><tr id="gr_svn82_386"

><td id="386"><a href="#386">386</a></td></tr
><tr id="gr_svn82_387"

><td id="387"><a href="#387">387</a></td></tr
><tr id="gr_svn82_388"

><td id="388"><a href="#388">388</a></td></tr
><tr id="gr_svn82_389"

><td id="389"><a href="#389">389</a></td></tr
><tr id="gr_svn82_390"

><td id="390"><a href="#390">390</a></td></tr
><tr id="gr_svn82_391"

><td id="391"><a href="#391">391</a></td></tr
><tr id="gr_svn82_392"

><td id="392"><a href="#392">392</a></td></tr
><tr id="gr_svn82_393"

><td id="393"><a href="#393">393</a></td></tr
><tr id="gr_svn82_394"

><td id="394"><a href="#394">394</a></td></tr
><tr id="gr_svn82_395"

><td id="395"><a href="#395">395</a></td></tr
><tr id="gr_svn82_396"

><td id="396"><a href="#396">396</a></td></tr
><tr id="gr_svn82_397"

><td id="397"><a href="#397">397</a></td></tr
><tr id="gr_svn82_398"

><td id="398"><a href="#398">398</a></td></tr
><tr id="gr_svn82_399"

><td id="399"><a href="#399">399</a></td></tr
><tr id="gr_svn82_400"

><td id="400"><a href="#400">400</a></td></tr
><tr id="gr_svn82_401"

><td id="401"><a href="#401">401</a></td></tr
><tr id="gr_svn82_402"

><td id="402"><a href="#402">402</a></td></tr
><tr id="gr_svn82_403"

><td id="403"><a href="#403">403</a></td></tr
><tr id="gr_svn82_404"

><td id="404"><a href="#404">404</a></td></tr
><tr id="gr_svn82_405"

><td id="405"><a href="#405">405</a></td></tr
><tr id="gr_svn82_406"

><td id="406"><a href="#406">406</a></td></tr
><tr id="gr_svn82_407"

><td id="407"><a href="#407">407</a></td></tr
><tr id="gr_svn82_408"

><td id="408"><a href="#408">408</a></td></tr
><tr id="gr_svn82_409"

><td id="409"><a href="#409">409</a></td></tr
><tr id="gr_svn82_410"

><td id="410"><a href="#410">410</a></td></tr
><tr id="gr_svn82_411"

><td id="411"><a href="#411">411</a></td></tr
><tr id="gr_svn82_412"

><td id="412"><a href="#412">412</a></td></tr
><tr id="gr_svn82_413"

><td id="413"><a href="#413">413</a></td></tr
><tr id="gr_svn82_414"

><td id="414"><a href="#414">414</a></td></tr
><tr id="gr_svn82_415"

><td id="415"><a href="#415">415</a></td></tr
><tr id="gr_svn82_416"

><td id="416"><a href="#416">416</a></td></tr
><tr id="gr_svn82_417"

><td id="417"><a href="#417">417</a></td></tr
><tr id="gr_svn82_418"

><td id="418"><a href="#418">418</a></td></tr
><tr id="gr_svn82_419"

><td id="419"><a href="#419">419</a></td></tr
><tr id="gr_svn82_420"

><td id="420"><a href="#420">420</a></td></tr
><tr id="gr_svn82_421"

><td id="421"><a href="#421">421</a></td></tr
><tr id="gr_svn82_422"

><td id="422"><a href="#422">422</a></td></tr
><tr id="gr_svn82_423"

><td id="423"><a href="#423">423</a></td></tr
><tr id="gr_svn82_424"

><td id="424"><a href="#424">424</a></td></tr
><tr id="gr_svn82_425"

><td id="425"><a href="#425">425</a></td></tr
><tr id="gr_svn82_426"

><td id="426"><a href="#426">426</a></td></tr
><tr id="gr_svn82_427"

><td id="427"><a href="#427">427</a></td></tr
><tr id="gr_svn82_428"

><td id="428"><a href="#428">428</a></td></tr
><tr id="gr_svn82_429"

><td id="429"><a href="#429">429</a></td></tr
><tr id="gr_svn82_430"

><td id="430"><a href="#430">430</a></td></tr
><tr id="gr_svn82_431"

><td id="431"><a href="#431">431</a></td></tr
><tr id="gr_svn82_432"

><td id="432"><a href="#432">432</a></td></tr
><tr id="gr_svn82_433"

><td id="433"><a href="#433">433</a></td></tr
><tr id="gr_svn82_434"

><td id="434"><a href="#434">434</a></td></tr
><tr id="gr_svn82_435"

><td id="435"><a href="#435">435</a></td></tr
><tr id="gr_svn82_436"

><td id="436"><a href="#436">436</a></td></tr
><tr id="gr_svn82_437"

><td id="437"><a href="#437">437</a></td></tr
><tr id="gr_svn82_438"

><td id="438"><a href="#438">438</a></td></tr
><tr id="gr_svn82_439"

><td id="439"><a href="#439">439</a></td></tr
><tr id="gr_svn82_440"

><td id="440"><a href="#440">440</a></td></tr
><tr id="gr_svn82_441"

><td id="441"><a href="#441">441</a></td></tr
><tr id="gr_svn82_442"

><td id="442"><a href="#442">442</a></td></tr
><tr id="gr_svn82_443"

><td id="443"><a href="#443">443</a></td></tr
><tr id="gr_svn82_444"

><td id="444"><a href="#444">444</a></td></tr
><tr id="gr_svn82_445"

><td id="445"><a href="#445">445</a></td></tr
><tr id="gr_svn82_446"

><td id="446"><a href="#446">446</a></td></tr
><tr id="gr_svn82_447"

><td id="447"><a href="#447">447</a></td></tr
><tr id="gr_svn82_448"

><td id="448"><a href="#448">448</a></td></tr
><tr id="gr_svn82_449"

><td id="449"><a href="#449">449</a></td></tr
><tr id="gr_svn82_450"

><td id="450"><a href="#450">450</a></td></tr
><tr id="gr_svn82_451"

><td id="451"><a href="#451">451</a></td></tr
><tr id="gr_svn82_452"

><td id="452"><a href="#452">452</a></td></tr
><tr id="gr_svn82_453"

><td id="453"><a href="#453">453</a></td></tr
><tr id="gr_svn82_454"

><td id="454"><a href="#454">454</a></td></tr
><tr id="gr_svn82_455"

><td id="455"><a href="#455">455</a></td></tr
><tr id="gr_svn82_456"

><td id="456"><a href="#456">456</a></td></tr
><tr id="gr_svn82_457"

><td id="457"><a href="#457">457</a></td></tr
><tr id="gr_svn82_458"

><td id="458"><a href="#458">458</a></td></tr
><tr id="gr_svn82_459"

><td id="459"><a href="#459">459</a></td></tr
><tr id="gr_svn82_460"

><td id="460"><a href="#460">460</a></td></tr
><tr id="gr_svn82_461"

><td id="461"><a href="#461">461</a></td></tr
><tr id="gr_svn82_462"

><td id="462"><a href="#462">462</a></td></tr
><tr id="gr_svn82_463"

><td id="463"><a href="#463">463</a></td></tr
><tr id="gr_svn82_464"

><td id="464"><a href="#464">464</a></td></tr
><tr id="gr_svn82_465"

><td id="465"><a href="#465">465</a></td></tr
><tr id="gr_svn82_466"

><td id="466"><a href="#466">466</a></td></tr
><tr id="gr_svn82_467"

><td id="467"><a href="#467">467</a></td></tr
><tr id="gr_svn82_468"

><td id="468"><a href="#468">468</a></td></tr
><tr id="gr_svn82_469"

><td id="469"><a href="#469">469</a></td></tr
><tr id="gr_svn82_470"

><td id="470"><a href="#470">470</a></td></tr
><tr id="gr_svn82_471"

><td id="471"><a href="#471">471</a></td></tr
><tr id="gr_svn82_472"

><td id="472"><a href="#472">472</a></td></tr
><tr id="gr_svn82_473"

><td id="473"><a href="#473">473</a></td></tr
><tr id="gr_svn82_474"

><td id="474"><a href="#474">474</a></td></tr
><tr id="gr_svn82_475"

><td id="475"><a href="#475">475</a></td></tr
><tr id="gr_svn82_476"

><td id="476"><a href="#476">476</a></td></tr
><tr id="gr_svn82_477"

><td id="477"><a href="#477">477</a></td></tr
><tr id="gr_svn82_478"

><td id="478"><a href="#478">478</a></td></tr
><tr id="gr_svn82_479"

><td id="479"><a href="#479">479</a></td></tr
><tr id="gr_svn82_480"

><td id="480"><a href="#480">480</a></td></tr
><tr id="gr_svn82_481"

><td id="481"><a href="#481">481</a></td></tr
><tr id="gr_svn82_482"

><td id="482"><a href="#482">482</a></td></tr
><tr id="gr_svn82_483"

><td id="483"><a href="#483">483</a></td></tr
><tr id="gr_svn82_484"

><td id="484"><a href="#484">484</a></td></tr
><tr id="gr_svn82_485"

><td id="485"><a href="#485">485</a></td></tr
><tr id="gr_svn82_486"

><td id="486"><a href="#486">486</a></td></tr
><tr id="gr_svn82_487"

><td id="487"><a href="#487">487</a></td></tr
><tr id="gr_svn82_488"

><td id="488"><a href="#488">488</a></td></tr
><tr id="gr_svn82_489"

><td id="489"><a href="#489">489</a></td></tr
><tr id="gr_svn82_490"

><td id="490"><a href="#490">490</a></td></tr
><tr id="gr_svn82_491"

><td id="491"><a href="#491">491</a></td></tr
><tr id="gr_svn82_492"

><td id="492"><a href="#492">492</a></td></tr
><tr id="gr_svn82_493"

><td id="493"><a href="#493">493</a></td></tr
><tr id="gr_svn82_494"

><td id="494"><a href="#494">494</a></td></tr
><tr id="gr_svn82_495"

><td id="495"><a href="#495">495</a></td></tr
><tr id="gr_svn82_496"

><td id="496"><a href="#496">496</a></td></tr
><tr id="gr_svn82_497"

><td id="497"><a href="#497">497</a></td></tr
><tr id="gr_svn82_498"

><td id="498"><a href="#498">498</a></td></tr
><tr id="gr_svn82_499"

><td id="499"><a href="#499">499</a></td></tr
><tr id="gr_svn82_500"

><td id="500"><a href="#500">500</a></td></tr
><tr id="gr_svn82_501"

><td id="501"><a href="#501">501</a></td></tr
><tr id="gr_svn82_502"

><td id="502"><a href="#502">502</a></td></tr
><tr id="gr_svn82_503"

><td id="503"><a href="#503">503</a></td></tr
><tr id="gr_svn82_504"

><td id="504"><a href="#504">504</a></td></tr
><tr id="gr_svn82_505"

><td id="505"><a href="#505">505</a></td></tr
><tr id="gr_svn82_506"

><td id="506"><a href="#506">506</a></td></tr
><tr id="gr_svn82_507"

><td id="507"><a href="#507">507</a></td></tr
><tr id="gr_svn82_508"

><td id="508"><a href="#508">508</a></td></tr
><tr id="gr_svn82_509"

><td id="509"><a href="#509">509</a></td></tr
><tr id="gr_svn82_510"

><td id="510"><a href="#510">510</a></td></tr
><tr id="gr_svn82_511"

><td id="511"><a href="#511">511</a></td></tr
><tr id="gr_svn82_512"

><td id="512"><a href="#512">512</a></td></tr
><tr id="gr_svn82_513"

><td id="513"><a href="#513">513</a></td></tr
><tr id="gr_svn82_514"

><td id="514"><a href="#514">514</a></td></tr
><tr id="gr_svn82_515"

><td id="515"><a href="#515">515</a></td></tr
><tr id="gr_svn82_516"

><td id="516"><a href="#516">516</a></td></tr
><tr id="gr_svn82_517"

><td id="517"><a href="#517">517</a></td></tr
><tr id="gr_svn82_518"

><td id="518"><a href="#518">518</a></td></tr
><tr id="gr_svn82_519"

><td id="519"><a href="#519">519</a></td></tr
><tr id="gr_svn82_520"

><td id="520"><a href="#520">520</a></td></tr
><tr id="gr_svn82_521"

><td id="521"><a href="#521">521</a></td></tr
><tr id="gr_svn82_522"

><td id="522"><a href="#522">522</a></td></tr
><tr id="gr_svn82_523"

><td id="523"><a href="#523">523</a></td></tr
><tr id="gr_svn82_524"

><td id="524"><a href="#524">524</a></td></tr
><tr id="gr_svn82_525"

><td id="525"><a href="#525">525</a></td></tr
><tr id="gr_svn82_526"

><td id="526"><a href="#526">526</a></td></tr
><tr id="gr_svn82_527"

><td id="527"><a href="#527">527</a></td></tr
><tr id="gr_svn82_528"

><td id="528"><a href="#528">528</a></td></tr
><tr id="gr_svn82_529"

><td id="529"><a href="#529">529</a></td></tr
><tr id="gr_svn82_530"

><td id="530"><a href="#530">530</a></td></tr
><tr id="gr_svn82_531"

><td id="531"><a href="#531">531</a></td></tr
><tr id="gr_svn82_532"

><td id="532"><a href="#532">532</a></td></tr
><tr id="gr_svn82_533"

><td id="533"><a href="#533">533</a></td></tr
><tr id="gr_svn82_534"

><td id="534"><a href="#534">534</a></td></tr
><tr id="gr_svn82_535"

><td id="535"><a href="#535">535</a></td></tr
><tr id="gr_svn82_536"

><td id="536"><a href="#536">536</a></td></tr
><tr id="gr_svn82_537"

><td id="537"><a href="#537">537</a></td></tr
><tr id="gr_svn82_538"

><td id="538"><a href="#538">538</a></td></tr
><tr id="gr_svn82_539"

><td id="539"><a href="#539">539</a></td></tr
><tr id="gr_svn82_540"

><td id="540"><a href="#540">540</a></td></tr
><tr id="gr_svn82_541"

><td id="541"><a href="#541">541</a></td></tr
><tr id="gr_svn82_542"

><td id="542"><a href="#542">542</a></td></tr
><tr id="gr_svn82_543"

><td id="543"><a href="#543">543</a></td></tr
><tr id="gr_svn82_544"

><td id="544"><a href="#544">544</a></td></tr
><tr id="gr_svn82_545"

><td id="545"><a href="#545">545</a></td></tr
><tr id="gr_svn82_546"

><td id="546"><a href="#546">546</a></td></tr
><tr id="gr_svn82_547"

><td id="547"><a href="#547">547</a></td></tr
><tr id="gr_svn82_548"

><td id="548"><a href="#548">548</a></td></tr
><tr id="gr_svn82_549"

><td id="549"><a href="#549">549</a></td></tr
><tr id="gr_svn82_550"

><td id="550"><a href="#550">550</a></td></tr
><tr id="gr_svn82_551"

><td id="551"><a href="#551">551</a></td></tr
><tr id="gr_svn82_552"

><td id="552"><a href="#552">552</a></td></tr
><tr id="gr_svn82_553"

><td id="553"><a href="#553">553</a></td></tr
><tr id="gr_svn82_554"

><td id="554"><a href="#554">554</a></td></tr
><tr id="gr_svn82_555"

><td id="555"><a href="#555">555</a></td></tr
><tr id="gr_svn82_556"

><td id="556"><a href="#556">556</a></td></tr
><tr id="gr_svn82_557"

><td id="557"><a href="#557">557</a></td></tr
><tr id="gr_svn82_558"

><td id="558"><a href="#558">558</a></td></tr
><tr id="gr_svn82_559"

><td id="559"><a href="#559">559</a></td></tr
><tr id="gr_svn82_560"

><td id="560"><a href="#560">560</a></td></tr
><tr id="gr_svn82_561"

><td id="561"><a href="#561">561</a></td></tr
><tr id="gr_svn82_562"

><td id="562"><a href="#562">562</a></td></tr
><tr id="gr_svn82_563"

><td id="563"><a href="#563">563</a></td></tr
><tr id="gr_svn82_564"

><td id="564"><a href="#564">564</a></td></tr
><tr id="gr_svn82_565"

><td id="565"><a href="#565">565</a></td></tr
><tr id="gr_svn82_566"

><td id="566"><a href="#566">566</a></td></tr
><tr id="gr_svn82_567"

><td id="567"><a href="#567">567</a></td></tr
><tr id="gr_svn82_568"

><td id="568"><a href="#568">568</a></td></tr
><tr id="gr_svn82_569"

><td id="569"><a href="#569">569</a></td></tr
><tr id="gr_svn82_570"

><td id="570"><a href="#570">570</a></td></tr
><tr id="gr_svn82_571"

><td id="571"><a href="#571">571</a></td></tr
><tr id="gr_svn82_572"

><td id="572"><a href="#572">572</a></td></tr
><tr id="gr_svn82_573"

><td id="573"><a href="#573">573</a></td></tr
><tr id="gr_svn82_574"

><td id="574"><a href="#574">574</a></td></tr
><tr id="gr_svn82_575"

><td id="575"><a href="#575">575</a></td></tr
><tr id="gr_svn82_576"

><td id="576"><a href="#576">576</a></td></tr
><tr id="gr_svn82_577"

><td id="577"><a href="#577">577</a></td></tr
><tr id="gr_svn82_578"

><td id="578"><a href="#578">578</a></td></tr
><tr id="gr_svn82_579"

><td id="579"><a href="#579">579</a></td></tr
><tr id="gr_svn82_580"

><td id="580"><a href="#580">580</a></td></tr
><tr id="gr_svn82_581"

><td id="581"><a href="#581">581</a></td></tr
><tr id="gr_svn82_582"

><td id="582"><a href="#582">582</a></td></tr
><tr id="gr_svn82_583"

><td id="583"><a href="#583">583</a></td></tr
><tr id="gr_svn82_584"

><td id="584"><a href="#584">584</a></td></tr
><tr id="gr_svn82_585"

><td id="585"><a href="#585">585</a></td></tr
><tr id="gr_svn82_586"

><td id="586"><a href="#586">586</a></td></tr
><tr id="gr_svn82_587"

><td id="587"><a href="#587">587</a></td></tr
><tr id="gr_svn82_588"

><td id="588"><a href="#588">588</a></td></tr
><tr id="gr_svn82_589"

><td id="589"><a href="#589">589</a></td></tr
><tr id="gr_svn82_590"

><td id="590"><a href="#590">590</a></td></tr
><tr id="gr_svn82_591"

><td id="591"><a href="#591">591</a></td></tr
><tr id="gr_svn82_592"

><td id="592"><a href="#592">592</a></td></tr
><tr id="gr_svn82_593"

><td id="593"><a href="#593">593</a></td></tr
><tr id="gr_svn82_594"

><td id="594"><a href="#594">594</a></td></tr
><tr id="gr_svn82_595"

><td id="595"><a href="#595">595</a></td></tr
><tr id="gr_svn82_596"

><td id="596"><a href="#596">596</a></td></tr
><tr id="gr_svn82_597"

><td id="597"><a href="#597">597</a></td></tr
><tr id="gr_svn82_598"

><td id="598"><a href="#598">598</a></td></tr
><tr id="gr_svn82_599"

><td id="599"><a href="#599">599</a></td></tr
><tr id="gr_svn82_600"

><td id="600"><a href="#600">600</a></td></tr
><tr id="gr_svn82_601"

><td id="601"><a href="#601">601</a></td></tr
><tr id="gr_svn82_602"

><td id="602"><a href="#602">602</a></td></tr
><tr id="gr_svn82_603"

><td id="603"><a href="#603">603</a></td></tr
><tr id="gr_svn82_604"

><td id="604"><a href="#604">604</a></td></tr
><tr id="gr_svn82_605"

><td id="605"><a href="#605">605</a></td></tr
><tr id="gr_svn82_606"

><td id="606"><a href="#606">606</a></td></tr
><tr id="gr_svn82_607"

><td id="607"><a href="#607">607</a></td></tr
><tr id="gr_svn82_608"

><td id="608"><a href="#608">608</a></td></tr
><tr id="gr_svn82_609"

><td id="609"><a href="#609">609</a></td></tr
><tr id="gr_svn82_610"

><td id="610"><a href="#610">610</a></td></tr
><tr id="gr_svn82_611"

><td id="611"><a href="#611">611</a></td></tr
><tr id="gr_svn82_612"

><td id="612"><a href="#612">612</a></td></tr
><tr id="gr_svn82_613"

><td id="613"><a href="#613">613</a></td></tr
><tr id="gr_svn82_614"

><td id="614"><a href="#614">614</a></td></tr
><tr id="gr_svn82_615"

><td id="615"><a href="#615">615</a></td></tr
><tr id="gr_svn82_616"

><td id="616"><a href="#616">616</a></td></tr
><tr id="gr_svn82_617"

><td id="617"><a href="#617">617</a></td></tr
><tr id="gr_svn82_618"

><td id="618"><a href="#618">618</a></td></tr
><tr id="gr_svn82_619"

><td id="619"><a href="#619">619</a></td></tr
><tr id="gr_svn82_620"

><td id="620"><a href="#620">620</a></td></tr
><tr id="gr_svn82_621"

><td id="621"><a href="#621">621</a></td></tr
><tr id="gr_svn82_622"

><td id="622"><a href="#622">622</a></td></tr
><tr id="gr_svn82_623"

><td id="623"><a href="#623">623</a></td></tr
><tr id="gr_svn82_624"

><td id="624"><a href="#624">624</a></td></tr
><tr id="gr_svn82_625"

><td id="625"><a href="#625">625</a></td></tr
><tr id="gr_svn82_626"

><td id="626"><a href="#626">626</a></td></tr
><tr id="gr_svn82_627"

><td id="627"><a href="#627">627</a></td></tr
><tr id="gr_svn82_628"

><td id="628"><a href="#628">628</a></td></tr
><tr id="gr_svn82_629"

><td id="629"><a href="#629">629</a></td></tr
><tr id="gr_svn82_630"

><td id="630"><a href="#630">630</a></td></tr
><tr id="gr_svn82_631"

><td id="631"><a href="#631">631</a></td></tr
><tr id="gr_svn82_632"

><td id="632"><a href="#632">632</a></td></tr
><tr id="gr_svn82_633"

><td id="633"><a href="#633">633</a></td></tr
><tr id="gr_svn82_634"

><td id="634"><a href="#634">634</a></td></tr
><tr id="gr_svn82_635"

><td id="635"><a href="#635">635</a></td></tr
><tr id="gr_svn82_636"

><td id="636"><a href="#636">636</a></td></tr
><tr id="gr_svn82_637"

><td id="637"><a href="#637">637</a></td></tr
><tr id="gr_svn82_638"

><td id="638"><a href="#638">638</a></td></tr
><tr id="gr_svn82_639"

><td id="639"><a href="#639">639</a></td></tr
><tr id="gr_svn82_640"

><td id="640"><a href="#640">640</a></td></tr
><tr id="gr_svn82_641"

><td id="641"><a href="#641">641</a></td></tr
><tr id="gr_svn82_642"

><td id="642"><a href="#642">642</a></td></tr
><tr id="gr_svn82_643"

><td id="643"><a href="#643">643</a></td></tr
><tr id="gr_svn82_644"

><td id="644"><a href="#644">644</a></td></tr
><tr id="gr_svn82_645"

><td id="645"><a href="#645">645</a></td></tr
><tr id="gr_svn82_646"

><td id="646"><a href="#646">646</a></td></tr
><tr id="gr_svn82_647"

><td id="647"><a href="#647">647</a></td></tr
><tr id="gr_svn82_648"

><td id="648"><a href="#648">648</a></td></tr
><tr id="gr_svn82_649"

><td id="649"><a href="#649">649</a></td></tr
><tr id="gr_svn82_650"

><td id="650"><a href="#650">650</a></td></tr
><tr id="gr_svn82_651"

><td id="651"><a href="#651">651</a></td></tr
><tr id="gr_svn82_652"

><td id="652"><a href="#652">652</a></td></tr
><tr id="gr_svn82_653"

><td id="653"><a href="#653">653</a></td></tr
><tr id="gr_svn82_654"

><td id="654"><a href="#654">654</a></td></tr
><tr id="gr_svn82_655"

><td id="655"><a href="#655">655</a></td></tr
><tr id="gr_svn82_656"

><td id="656"><a href="#656">656</a></td></tr
><tr id="gr_svn82_657"

><td id="657"><a href="#657">657</a></td></tr
><tr id="gr_svn82_658"

><td id="658"><a href="#658">658</a></td></tr
><tr id="gr_svn82_659"

><td id="659"><a href="#659">659</a></td></tr
><tr id="gr_svn82_660"

><td id="660"><a href="#660">660</a></td></tr
><tr id="gr_svn82_661"

><td id="661"><a href="#661">661</a></td></tr
><tr id="gr_svn82_662"

><td id="662"><a href="#662">662</a></td></tr
><tr id="gr_svn82_663"

><td id="663"><a href="#663">663</a></td></tr
><tr id="gr_svn82_664"

><td id="664"><a href="#664">664</a></td></tr
><tr id="gr_svn82_665"

><td id="665"><a href="#665">665</a></td></tr
><tr id="gr_svn82_666"

><td id="666"><a href="#666">666</a></td></tr
><tr id="gr_svn82_667"

><td id="667"><a href="#667">667</a></td></tr
><tr id="gr_svn82_668"

><td id="668"><a href="#668">668</a></td></tr
><tr id="gr_svn82_669"

><td id="669"><a href="#669">669</a></td></tr
><tr id="gr_svn82_670"

><td id="670"><a href="#670">670</a></td></tr
><tr id="gr_svn82_671"

><td id="671"><a href="#671">671</a></td></tr
><tr id="gr_svn82_672"

><td id="672"><a href="#672">672</a></td></tr
><tr id="gr_svn82_673"

><td id="673"><a href="#673">673</a></td></tr
><tr id="gr_svn82_674"

><td id="674"><a href="#674">674</a></td></tr
><tr id="gr_svn82_675"

><td id="675"><a href="#675">675</a></td></tr
><tr id="gr_svn82_676"

><td id="676"><a href="#676">676</a></td></tr
><tr id="gr_svn82_677"

><td id="677"><a href="#677">677</a></td></tr
><tr id="gr_svn82_678"

><td id="678"><a href="#678">678</a></td></tr
><tr id="gr_svn82_679"

><td id="679"><a href="#679">679</a></td></tr
><tr id="gr_svn82_680"

><td id="680"><a href="#680">680</a></td></tr
><tr id="gr_svn82_681"

><td id="681"><a href="#681">681</a></td></tr
><tr id="gr_svn82_682"

><td id="682"><a href="#682">682</a></td></tr
><tr id="gr_svn82_683"

><td id="683"><a href="#683">683</a></td></tr
><tr id="gr_svn82_684"

><td id="684"><a href="#684">684</a></td></tr
><tr id="gr_svn82_685"

><td id="685"><a href="#685">685</a></td></tr
><tr id="gr_svn82_686"

><td id="686"><a href="#686">686</a></td></tr
><tr id="gr_svn82_687"

><td id="687"><a href="#687">687</a></td></tr
><tr id="gr_svn82_688"

><td id="688"><a href="#688">688</a></td></tr
><tr id="gr_svn82_689"

><td id="689"><a href="#689">689</a></td></tr
><tr id="gr_svn82_690"

><td id="690"><a href="#690">690</a></td></tr
><tr id="gr_svn82_691"

><td id="691"><a href="#691">691</a></td></tr
><tr id="gr_svn82_692"

><td id="692"><a href="#692">692</a></td></tr
><tr id="gr_svn82_693"

><td id="693"><a href="#693">693</a></td></tr
><tr id="gr_svn82_694"

><td id="694"><a href="#694">694</a></td></tr
><tr id="gr_svn82_695"

><td id="695"><a href="#695">695</a></td></tr
><tr id="gr_svn82_696"

><td id="696"><a href="#696">696</a></td></tr
><tr id="gr_svn82_697"

><td id="697"><a href="#697">697</a></td></tr
><tr id="gr_svn82_698"

><td id="698"><a href="#698">698</a></td></tr
><tr id="gr_svn82_699"

><td id="699"><a href="#699">699</a></td></tr
><tr id="gr_svn82_700"

><td id="700"><a href="#700">700</a></td></tr
><tr id="gr_svn82_701"

><td id="701"><a href="#701">701</a></td></tr
><tr id="gr_svn82_702"

><td id="702"><a href="#702">702</a></td></tr
><tr id="gr_svn82_703"

><td id="703"><a href="#703">703</a></td></tr
><tr id="gr_svn82_704"

><td id="704"><a href="#704">704</a></td></tr
><tr id="gr_svn82_705"

><td id="705"><a href="#705">705</a></td></tr
><tr id="gr_svn82_706"

><td id="706"><a href="#706">706</a></td></tr
><tr id="gr_svn82_707"

><td id="707"><a href="#707">707</a></td></tr
><tr id="gr_svn82_708"

><td id="708"><a href="#708">708</a></td></tr
><tr id="gr_svn82_709"

><td id="709"><a href="#709">709</a></td></tr
><tr id="gr_svn82_710"

><td id="710"><a href="#710">710</a></td></tr
><tr id="gr_svn82_711"

><td id="711"><a href="#711">711</a></td></tr
><tr id="gr_svn82_712"

><td id="712"><a href="#712">712</a></td></tr
><tr id="gr_svn82_713"

><td id="713"><a href="#713">713</a></td></tr
><tr id="gr_svn82_714"

><td id="714"><a href="#714">714</a></td></tr
><tr id="gr_svn82_715"

><td id="715"><a href="#715">715</a></td></tr
><tr id="gr_svn82_716"

><td id="716"><a href="#716">716</a></td></tr
><tr id="gr_svn82_717"

><td id="717"><a href="#717">717</a></td></tr
><tr id="gr_svn82_718"

><td id="718"><a href="#718">718</a></td></tr
><tr id="gr_svn82_719"

><td id="719"><a href="#719">719</a></td></tr
><tr id="gr_svn82_720"

><td id="720"><a href="#720">720</a></td></tr
><tr id="gr_svn82_721"

><td id="721"><a href="#721">721</a></td></tr
><tr id="gr_svn82_722"

><td id="722"><a href="#722">722</a></td></tr
><tr id="gr_svn82_723"

><td id="723"><a href="#723">723</a></td></tr
><tr id="gr_svn82_724"

><td id="724"><a href="#724">724</a></td></tr
><tr id="gr_svn82_725"

><td id="725"><a href="#725">725</a></td></tr
><tr id="gr_svn82_726"

><td id="726"><a href="#726">726</a></td></tr
><tr id="gr_svn82_727"

><td id="727"><a href="#727">727</a></td></tr
><tr id="gr_svn82_728"

><td id="728"><a href="#728">728</a></td></tr
><tr id="gr_svn82_729"

><td id="729"><a href="#729">729</a></td></tr
><tr id="gr_svn82_730"

><td id="730"><a href="#730">730</a></td></tr
><tr id="gr_svn82_731"

><td id="731"><a href="#731">731</a></td></tr
><tr id="gr_svn82_732"

><td id="732"><a href="#732">732</a></td></tr
><tr id="gr_svn82_733"

><td id="733"><a href="#733">733</a></td></tr
><tr id="gr_svn82_734"

><td id="734"><a href="#734">734</a></td></tr
><tr id="gr_svn82_735"

><td id="735"><a href="#735">735</a></td></tr
><tr id="gr_svn82_736"

><td id="736"><a href="#736">736</a></td></tr
><tr id="gr_svn82_737"

><td id="737"><a href="#737">737</a></td></tr
><tr id="gr_svn82_738"

><td id="738"><a href="#738">738</a></td></tr
><tr id="gr_svn82_739"

><td id="739"><a href="#739">739</a></td></tr
><tr id="gr_svn82_740"

><td id="740"><a href="#740">740</a></td></tr
><tr id="gr_svn82_741"

><td id="741"><a href="#741">741</a></td></tr
><tr id="gr_svn82_742"

><td id="742"><a href="#742">742</a></td></tr
><tr id="gr_svn82_743"

><td id="743"><a href="#743">743</a></td></tr
><tr id="gr_svn82_744"

><td id="744"><a href="#744">744</a></td></tr
><tr id="gr_svn82_745"

><td id="745"><a href="#745">745</a></td></tr
><tr id="gr_svn82_746"

><td id="746"><a href="#746">746</a></td></tr
><tr id="gr_svn82_747"

><td id="747"><a href="#747">747</a></td></tr
><tr id="gr_svn82_748"

><td id="748"><a href="#748">748</a></td></tr
><tr id="gr_svn82_749"

><td id="749"><a href="#749">749</a></td></tr
><tr id="gr_svn82_750"

><td id="750"><a href="#750">750</a></td></tr
><tr id="gr_svn82_751"

><td id="751"><a href="#751">751</a></td></tr
><tr id="gr_svn82_752"

><td id="752"><a href="#752">752</a></td></tr
><tr id="gr_svn82_753"

><td id="753"><a href="#753">753</a></td></tr
><tr id="gr_svn82_754"

><td id="754"><a href="#754">754</a></td></tr
><tr id="gr_svn82_755"

><td id="755"><a href="#755">755</a></td></tr
><tr id="gr_svn82_756"

><td id="756"><a href="#756">756</a></td></tr
><tr id="gr_svn82_757"

><td id="757"><a href="#757">757</a></td></tr
><tr id="gr_svn82_758"

><td id="758"><a href="#758">758</a></td></tr
><tr id="gr_svn82_759"

><td id="759"><a href="#759">759</a></td></tr
><tr id="gr_svn82_760"

><td id="760"><a href="#760">760</a></td></tr
><tr id="gr_svn82_761"

><td id="761"><a href="#761">761</a></td></tr
><tr id="gr_svn82_762"

><td id="762"><a href="#762">762</a></td></tr
><tr id="gr_svn82_763"

><td id="763"><a href="#763">763</a></td></tr
><tr id="gr_svn82_764"

><td id="764"><a href="#764">764</a></td></tr
><tr id="gr_svn82_765"

><td id="765"><a href="#765">765</a></td></tr
><tr id="gr_svn82_766"

><td id="766"><a href="#766">766</a></td></tr
><tr id="gr_svn82_767"

><td id="767"><a href="#767">767</a></td></tr
><tr id="gr_svn82_768"

><td id="768"><a href="#768">768</a></td></tr
><tr id="gr_svn82_769"

><td id="769"><a href="#769">769</a></td></tr
><tr id="gr_svn82_770"

><td id="770"><a href="#770">770</a></td></tr
><tr id="gr_svn82_771"

><td id="771"><a href="#771">771</a></td></tr
><tr id="gr_svn82_772"

><td id="772"><a href="#772">772</a></td></tr
><tr id="gr_svn82_773"

><td id="773"><a href="#773">773</a></td></tr
><tr id="gr_svn82_774"

><td id="774"><a href="#774">774</a></td></tr
><tr id="gr_svn82_775"

><td id="775"><a href="#775">775</a></td></tr
><tr id="gr_svn82_776"

><td id="776"><a href="#776">776</a></td></tr
><tr id="gr_svn82_777"

><td id="777"><a href="#777">777</a></td></tr
><tr id="gr_svn82_778"

><td id="778"><a href="#778">778</a></td></tr
><tr id="gr_svn82_779"

><td id="779"><a href="#779">779</a></td></tr
><tr id="gr_svn82_780"

><td id="780"><a href="#780">780</a></td></tr
><tr id="gr_svn82_781"

><td id="781"><a href="#781">781</a></td></tr
><tr id="gr_svn82_782"

><td id="782"><a href="#782">782</a></td></tr
><tr id="gr_svn82_783"

><td id="783"><a href="#783">783</a></td></tr
><tr id="gr_svn82_784"

><td id="784"><a href="#784">784</a></td></tr
><tr id="gr_svn82_785"

><td id="785"><a href="#785">785</a></td></tr
><tr id="gr_svn82_786"

><td id="786"><a href="#786">786</a></td></tr
><tr id="gr_svn82_787"

><td id="787"><a href="#787">787</a></td></tr
><tr id="gr_svn82_788"

><td id="788"><a href="#788">788</a></td></tr
><tr id="gr_svn82_789"

><td id="789"><a href="#789">789</a></td></tr
><tr id="gr_svn82_790"

><td id="790"><a href="#790">790</a></td></tr
><tr id="gr_svn82_791"

><td id="791"><a href="#791">791</a></td></tr
><tr id="gr_svn82_792"

><td id="792"><a href="#792">792</a></td></tr
><tr id="gr_svn82_793"

><td id="793"><a href="#793">793</a></td></tr
><tr id="gr_svn82_794"

><td id="794"><a href="#794">794</a></td></tr
><tr id="gr_svn82_795"

><td id="795"><a href="#795">795</a></td></tr
><tr id="gr_svn82_796"

><td id="796"><a href="#796">796</a></td></tr
><tr id="gr_svn82_797"

><td id="797"><a href="#797">797</a></td></tr
><tr id="gr_svn82_798"

><td id="798"><a href="#798">798</a></td></tr
><tr id="gr_svn82_799"

><td id="799"><a href="#799">799</a></td></tr
><tr id="gr_svn82_800"

><td id="800"><a href="#800">800</a></td></tr
><tr id="gr_svn82_801"

><td id="801"><a href="#801">801</a></td></tr
><tr id="gr_svn82_802"

><td id="802"><a href="#802">802</a></td></tr
><tr id="gr_svn82_803"

><td id="803"><a href="#803">803</a></td></tr
><tr id="gr_svn82_804"

><td id="804"><a href="#804">804</a></td></tr
><tr id="gr_svn82_805"

><td id="805"><a href="#805">805</a></td></tr
><tr id="gr_svn82_806"

><td id="806"><a href="#806">806</a></td></tr
><tr id="gr_svn82_807"

><td id="807"><a href="#807">807</a></td></tr
><tr id="gr_svn82_808"

><td id="808"><a href="#808">808</a></td></tr
><tr id="gr_svn82_809"

><td id="809"><a href="#809">809</a></td></tr
><tr id="gr_svn82_810"

><td id="810"><a href="#810">810</a></td></tr
><tr id="gr_svn82_811"

><td id="811"><a href="#811">811</a></td></tr
><tr id="gr_svn82_812"

><td id="812"><a href="#812">812</a></td></tr
><tr id="gr_svn82_813"

><td id="813"><a href="#813">813</a></td></tr
><tr id="gr_svn82_814"

><td id="814"><a href="#814">814</a></td></tr
><tr id="gr_svn82_815"

><td id="815"><a href="#815">815</a></td></tr
><tr id="gr_svn82_816"

><td id="816"><a href="#816">816</a></td></tr
><tr id="gr_svn82_817"

><td id="817"><a href="#817">817</a></td></tr
><tr id="gr_svn82_818"

><td id="818"><a href="#818">818</a></td></tr
><tr id="gr_svn82_819"

><td id="819"><a href="#819">819</a></td></tr
><tr id="gr_svn82_820"

><td id="820"><a href="#820">820</a></td></tr
><tr id="gr_svn82_821"

><td id="821"><a href="#821">821</a></td></tr
><tr id="gr_svn82_822"

><td id="822"><a href="#822">822</a></td></tr
><tr id="gr_svn82_823"

><td id="823"><a href="#823">823</a></td></tr
><tr id="gr_svn82_824"

><td id="824"><a href="#824">824</a></td></tr
><tr id="gr_svn82_825"

><td id="825"><a href="#825">825</a></td></tr
><tr id="gr_svn82_826"

><td id="826"><a href="#826">826</a></td></tr
><tr id="gr_svn82_827"

><td id="827"><a href="#827">827</a></td></tr
><tr id="gr_svn82_828"

><td id="828"><a href="#828">828</a></td></tr
><tr id="gr_svn82_829"

><td id="829"><a href="#829">829</a></td></tr
></table></pre>
<pre><table width="100%"><tr class="nocursor"><td></td></tr></table></pre>
</td>
<td id="lines">
<pre><table width="100%"><tr class="cursor_stop cursor_hidden"><td></td></tr></table></pre>
<pre class="prettyprint lang-js"><table id="src_table_0"><tr
id=sl_svn82_1

><td class="source">﻿/*<br></td></tr
><tr
id=sl_svn82_2

><td class="source">* File:        jquery.dataTables.columnFilter.js<br></td></tr
><tr
id=sl_svn82_3

><td class="source">* Version:     1.5.6.<br></td></tr
><tr
id=sl_svn82_4

><td class="source">* Author:      Jovan Popovic <br></td></tr
><tr
id=sl_svn82_5

><td class="source">* <br></td></tr
><tr
id=sl_svn82_6

><td class="source">* Copyright 2011-2014 Jovan Popovic, all rights reserved.<br></td></tr
><tr
id=sl_svn82_7

><td class="source">*<br></td></tr
><tr
id=sl_svn82_8

><td class="source">* This source file is free software, under either the GPL v2 license or a<br></td></tr
><tr
id=sl_svn82_9

><td class="source">* BSD style license, as supplied with this software.<br></td></tr
><tr
id=sl_svn82_10

><td class="source">* <br></td></tr
><tr
id=sl_svn82_11

><td class="source">* This source file is distributed in the hope that it will be useful, but <br></td></tr
><tr
id=sl_svn82_12

><td class="source">* WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY <br></td></tr
><tr
id=sl_svn82_13

><td class="source">* or FITNESS FOR A PARTICULAR PURPOSE. <br></td></tr
><tr
id=sl_svn82_14

><td class="source">* <br></td></tr
><tr
id=sl_svn82_15

><td class="source">* Parameters:&quot;<br></td></tr
><tr
id=sl_svn82_16

><td class="source">* @sPlaceHolder                 String      Place where inline filtering function should be placed (&quot;tfoot&quot;, &quot;thead:before&quot;, &quot;thead:after&quot;). Default is &quot;tfoot&quot;<br></td></tr
><tr
id=sl_svn82_17

><td class="source">* @sRangeSeparator              String      Separator that will be used when range values are sent to the server-side. Default value is &quot;~&quot;.<br></td></tr
><tr
id=sl_svn82_18

><td class="source">* @sRangeFormat                 string      Default format of the From ... to ... range inputs. Default is From {from} to {to}<br></td></tr
><tr
id=sl_svn82_19

><td class="source">* @aoColumns                    Array       Array of the filter settings that will be applied on the columns<br></td></tr
><tr
id=sl_svn82_20

><td class="source">*/<br></td></tr
><tr
id=sl_svn82_21

><td class="source">(function ($) {<br></td></tr
><tr
id=sl_svn82_22

><td class="source"><br></td></tr
><tr
id=sl_svn82_23

><td class="source"><br></td></tr
><tr
id=sl_svn82_24

><td class="source">    $.fn.columnFilter = function (options) {<br></td></tr
><tr
id=sl_svn82_25

><td class="source"><br></td></tr
><tr
id=sl_svn82_26

><td class="source">        var asInitVals, i, label, th;<br></td></tr
><tr
id=sl_svn82_27

><td class="source"><br></td></tr
><tr
id=sl_svn82_28

><td class="source">        //var sTableId = &quot;table&quot;;<br></td></tr
><tr
id=sl_svn82_29

><td class="source">        var sRangeFormat = &quot;From {from} to {to}&quot;;<br></td></tr
><tr
id=sl_svn82_30

><td class="source">        //Array of the functions that will override sSearch_ parameters<br></td></tr
><tr
id=sl_svn82_31

><td class="source">        var afnSearch_ = new Array();<br></td></tr
><tr
id=sl_svn82_32

><td class="source">        var aiCustomSearch_Indexes = new Array();<br></td></tr
><tr
id=sl_svn82_33

><td class="source"><br></td></tr
><tr
id=sl_svn82_34

><td class="source">        var oFunctionTimeout = null;<br></td></tr
><tr
id=sl_svn82_35

><td class="source"><br></td></tr
><tr
id=sl_svn82_36

><td class="source">        var fnOnFiltered = function () { };<br></td></tr
><tr
id=sl_svn82_37

><td class="source"><br></td></tr
><tr
id=sl_svn82_38

><td class="source">        function _fnGetColumnValues(oSettings, iColumn, bUnique, bFiltered, bIgnoreEmpty) {<br></td></tr
><tr
id=sl_svn82_39

><td class="source">            ///&lt;summary&gt;<br></td></tr
><tr
id=sl_svn82_40

><td class="source">            ///Return values in the column<br></td></tr
><tr
id=sl_svn82_41

><td class="source">            ///&lt;/summary&gt;<br></td></tr
><tr
id=sl_svn82_42

><td class="source">            ///&lt;param name=&quot;oSettings&quot; type=&quot;Object&quot;&gt;DataTables settings&lt;/param&gt;<br></td></tr
><tr
id=sl_svn82_43

><td class="source">            ///&lt;param name=&quot;iColumn&quot; type=&quot;int&quot;&gt;Id of the column&lt;/param&gt;<br></td></tr
><tr
id=sl_svn82_44

><td class="source">            ///&lt;param name=&quot;bUnique&quot; type=&quot;bool&quot;&gt;Return only distinct values&lt;/param&gt;<br></td></tr
><tr
id=sl_svn82_45

><td class="source">            ///&lt;param name=&quot;bFiltered&quot; type=&quot;bool&quot;&gt;Return values only from the filtered rows&lt;/param&gt;<br></td></tr
><tr
id=sl_svn82_46

><td class="source">            ///&lt;param name=&quot;bIgnoreEmpty&quot; type=&quot;bool&quot;&gt;Ignore empty cells&lt;/param&gt;<br></td></tr
><tr
id=sl_svn82_47

><td class="source"><br></td></tr
><tr
id=sl_svn82_48

><td class="source">            // check that we have a column id<br></td></tr
><tr
id=sl_svn82_49

><td class="source">            if (typeof iColumn == &quot;undefined&quot;) return new Array();<br></td></tr
><tr
id=sl_svn82_50

><td class="source"><br></td></tr
><tr
id=sl_svn82_51

><td class="source">            // by default we only wany unique data<br></td></tr
><tr
id=sl_svn82_52

><td class="source">            if (typeof bUnique == &quot;undefined&quot;) bUnique = true;<br></td></tr
><tr
id=sl_svn82_53

><td class="source"><br></td></tr
><tr
id=sl_svn82_54

><td class="source">            // by default we do want to only look at filtered data<br></td></tr
><tr
id=sl_svn82_55

><td class="source">            if (typeof bFiltered == &quot;undefined&quot;) bFiltered = true;<br></td></tr
><tr
id=sl_svn82_56

><td class="source"><br></td></tr
><tr
id=sl_svn82_57

><td class="source">            // by default we do not wany to include empty values<br></td></tr
><tr
id=sl_svn82_58

><td class="source">            if (typeof bIgnoreEmpty == &quot;undefined&quot;) bIgnoreEmpty = true;<br></td></tr
><tr
id=sl_svn82_59

><td class="source"><br></td></tr
><tr
id=sl_svn82_60

><td class="source">            // list of rows which we&#39;re going to loop through<br></td></tr
><tr
id=sl_svn82_61

><td class="source">            var aiRows;<br></td></tr
><tr
id=sl_svn82_62

><td class="source"><br></td></tr
><tr
id=sl_svn82_63

><td class="source">            // use only filtered rows<br></td></tr
><tr
id=sl_svn82_64

><td class="source">            if (bFiltered == true) aiRows = oSettings.aiDisplay;<br></td></tr
><tr
id=sl_svn82_65

><td class="source">            // use all rows<br></td></tr
><tr
id=sl_svn82_66

><td class="source">            else aiRows = oSettings.aiDisplayMaster; // all row numbers<br></td></tr
><tr
id=sl_svn82_67

><td class="source"><br></td></tr
><tr
id=sl_svn82_68

><td class="source">            // set up data array	<br></td></tr
><tr
id=sl_svn82_69

><td class="source">            var asResultData = new Array();<br></td></tr
><tr
id=sl_svn82_70

><td class="source"><br></td></tr
><tr
id=sl_svn82_71

><td class="source">            for (var i = 0, c = aiRows.length; i &lt; c; i++) {<br></td></tr
><tr
id=sl_svn82_72

><td class="source">                var iRow = aiRows[i];<br></td></tr
><tr
id=sl_svn82_73

><td class="source">                var aData = oTable.fnGetData(iRow);<br></td></tr
><tr
id=sl_svn82_74

><td class="source">                var sValue = aData[iColumn];<br></td></tr
><tr
id=sl_svn82_75

><td class="source"><br></td></tr
><tr
id=sl_svn82_76

><td class="source">                // ignore empty values?<br></td></tr
><tr
id=sl_svn82_77

><td class="source">                if (bIgnoreEmpty == true &amp;&amp; sValue.length == 0) continue;<br></td></tr
><tr
id=sl_svn82_78

><td class="source"><br></td></tr
><tr
id=sl_svn82_79

><td class="source">                // ignore unique values?<br></td></tr
><tr
id=sl_svn82_80

><td class="source">                else if (bUnique == true &amp;&amp; jQuery.inArray(sValue, asResultData) &gt; -1) continue;<br></td></tr
><tr
id=sl_svn82_81

><td class="source"><br></td></tr
><tr
id=sl_svn82_82

><td class="source">                // else push the value onto the result data array<br></td></tr
><tr
id=sl_svn82_83

><td class="source">                else asResultData.push(sValue);<br></td></tr
><tr
id=sl_svn82_84

><td class="source">            }<br></td></tr
><tr
id=sl_svn82_85

><td class="source"><br></td></tr
><tr
id=sl_svn82_86

><td class="source">            return asResultData.sort();<br></td></tr
><tr
id=sl_svn82_87

><td class="source">        }<br></td></tr
><tr
id=sl_svn82_88

><td class="source"><br></td></tr
><tr
id=sl_svn82_89

><td class="source">        function _fnColumnIndex(iColumnIndex) {<br></td></tr
><tr
id=sl_svn82_90

><td class="source">            if (properties.bUseColVis)<br></td></tr
><tr
id=sl_svn82_91

><td class="source">                return iColumnIndex;<br></td></tr
><tr
id=sl_svn82_92

><td class="source">            else<br></td></tr
><tr
id=sl_svn82_93

><td class="source">                return oTable.fnSettings().oApi._fnVisibleToColumnIndex(oTable.fnSettings(), iColumnIndex);<br></td></tr
><tr
id=sl_svn82_94

><td class="source">            //return iColumnIndex;<br></td></tr
><tr
id=sl_svn82_95

><td class="source">            //return oTable.fnSettings().oApi._fnColumnIndexToVisible(oTable.fnSettings(), iColumnIndex);<br></td></tr
><tr
id=sl_svn82_96

><td class="source">        }<br></td></tr
><tr
id=sl_svn82_97

><td class="source"><br></td></tr
><tr
id=sl_svn82_98

><td class="source">        function fnCreateInput(oTable, regex, smart, bIsNumber, iFilterLength, iMaxLenght) {<br></td></tr
><tr
id=sl_svn82_99

><td class="source">            var sCSSClass = &quot;text_filter form-control&quot;;<br></td></tr
><tr
id=sl_svn82_100

><td class="source">            if (bIsNumber)<br></td></tr
><tr
id=sl_svn82_101

><td class="source">                sCSSClass = &quot;number_filter form-control&quot;;<br></td></tr
><tr
id=sl_svn82_102

><td class="source"><br></td></tr
><tr
id=sl_svn82_103

><td class="source">            label = label.replace(/(^\s*)|(\s*$)/g, &quot;&quot;);<br></td></tr
><tr
id=sl_svn82_104

><td class="source">            var currentFilter = oTable.fnSettings().aoPreSearchCols[i].sSearch;<br></td></tr
><tr
id=sl_svn82_105

><td class="source">            var search_init = &#39;search_init &#39;;<br></td></tr
><tr
id=sl_svn82_106

><td class="source">            var inputvalue = label;<br></td></tr
><tr
id=sl_svn82_107

><td class="source">            if (currentFilter != &#39;&#39; &amp;&amp; currentFilter != &#39;^&#39;) {<br></td></tr
><tr
id=sl_svn82_108

><td class="source">                if (bIsNumber &amp;&amp; currentFilter.charAt(0) == &#39;^&#39;)<br></td></tr
><tr
id=sl_svn82_109

><td class="source">                    inputvalue = currentFilter.substr(1); //ignore trailing ^<br></td></tr
><tr
id=sl_svn82_110

><td class="source">                else<br></td></tr
><tr
id=sl_svn82_111

><td class="source">                    inputvalue = currentFilter;<br></td></tr
><tr
id=sl_svn82_112

><td class="source">                search_init = &#39;&#39;;<br></td></tr
><tr
id=sl_svn82_113

><td class="source">            }<br></td></tr
><tr
id=sl_svn82_114

><td class="source"><br></td></tr
><tr
id=sl_svn82_115

><td class="source">            var input = $(&#39;&lt;input type=&quot;text&quot; class=&quot;&#39; + search_init + sCSSClass + &#39;&quot; value=&quot;&#39; + inputvalue + &#39;&quot; rel=&quot;&#39; + i + &#39;&quot;/&gt;&#39;);<br></td></tr
><tr
id=sl_svn82_116

><td class="source">            if (iMaxLenght != undefined &amp;&amp; iMaxLenght != -1) {<br></td></tr
><tr
id=sl_svn82_117

><td class="source">                input.attr(&#39;maxlength&#39;, iMaxLenght);<br></td></tr
><tr
id=sl_svn82_118

><td class="source">            }<br></td></tr
><tr
id=sl_svn82_119

><td class="source">            th.html(input);<br></td></tr
><tr
id=sl_svn82_120

><td class="source">            if (bIsNumber)<br></td></tr
><tr
id=sl_svn82_121

><td class="source">                th.wrapInner(&#39;&lt;span class=&quot;filter_column filter_number&quot; /&gt;&#39;);<br></td></tr
><tr
id=sl_svn82_122

><td class="source">            else<br></td></tr
><tr
id=sl_svn82_123

><td class="source">                th.wrapInner(&#39;&lt;span class=&quot;filter_column filter_text&quot; /&gt;&#39;);<br></td></tr
><tr
id=sl_svn82_124

><td class="source"><br></td></tr
><tr
id=sl_svn82_125

><td class="source">            asInitVals[i] = label;<br></td></tr
><tr
id=sl_svn82_126

><td class="source">            var index = i;<br></td></tr
><tr
id=sl_svn82_127

><td class="source"><br></td></tr
><tr
id=sl_svn82_128

><td class="source">            if (bIsNumber &amp;&amp; !oTable.fnSettings().oFeatures.bServerSide) {<br></td></tr
><tr
id=sl_svn82_129

><td class="source">                input.keyup(function () {<br></td></tr
><tr
id=sl_svn82_130

><td class="source">                    /* Filter on the column all numbers that starts with the entered value */<br></td></tr
><tr
id=sl_svn82_131

><td class="source">                    oTable.fnFilter(&#39;^&#39; + this.value, _fnColumnIndex(index), true, false); //Issue 37<br></td></tr
><tr
id=sl_svn82_132

><td class="source">                    fnOnFiltered();<br></td></tr
><tr
id=sl_svn82_133

><td class="source">                });<br></td></tr
><tr
id=sl_svn82_134

><td class="source">            } else {<br></td></tr
><tr
id=sl_svn82_135

><td class="source">                input.keyup(function () {<br></td></tr
><tr
id=sl_svn82_136

><td class="source">                    if (oTable.fnSettings().oFeatures.bServerSide &amp;&amp; iFilterLength != 0) {<br></td></tr
><tr
id=sl_svn82_137

><td class="source">                        //If filter length is set in the server-side processing mode<br></td></tr
><tr
id=sl_svn82_138

><td class="source">                        //Check has the user entered at least iFilterLength new characters<br></td></tr
><tr
id=sl_svn82_139

><td class="source"><br></td></tr
><tr
id=sl_svn82_140

><td class="source">                        var currentFilter = oTable.fnSettings().aoPreSearchCols[index].sSearch;<br></td></tr
><tr
id=sl_svn82_141

><td class="source">                        var iLastFilterLength = $(this).data(&quot;dt-iLastFilterLength&quot;);<br></td></tr
><tr
id=sl_svn82_142

><td class="source">                        if (typeof iLastFilterLength == &quot;undefined&quot;)<br></td></tr
><tr
id=sl_svn82_143

><td class="source">                            iLastFilterLength = 0;<br></td></tr
><tr
id=sl_svn82_144

><td class="source">                        var iCurrentFilterLength = this.value.length;<br></td></tr
><tr
id=sl_svn82_145

><td class="source">                        if (Math.abs(iCurrentFilterLength - iLastFilterLength) &lt; iFilterLength<br></td></tr
><tr
id=sl_svn82_146

><td class="source">                        //&amp;&amp; currentFilter.length == 0 //Why this?<br></td></tr
><tr
id=sl_svn82_147

><td class="source">					        ) {<br></td></tr
><tr
id=sl_svn82_148

><td class="source">                            //Cancel the filtering<br></td></tr
><tr
id=sl_svn82_149

><td class="source">                            return;<br></td></tr
><tr
id=sl_svn82_150

><td class="source">                        }<br></td></tr
><tr
id=sl_svn82_151

><td class="source">                        else {<br></td></tr
><tr
id=sl_svn82_152

><td class="source">                            //Remember the current filter length<br></td></tr
><tr
id=sl_svn82_153

><td class="source">                            $(this).data(&quot;dt-iLastFilterLength&quot;, iCurrentFilterLength);<br></td></tr
><tr
id=sl_svn82_154

><td class="source">                        }<br></td></tr
><tr
id=sl_svn82_155

><td class="source">                    }<br></td></tr
><tr
id=sl_svn82_156

><td class="source">                    /* Filter on the column (the index) of this element */<br></td></tr
><tr
id=sl_svn82_157

><td class="source">                    oTable.fnFilter(this.value, _fnColumnIndex(index), regex, smart); //Issue 37<br></td></tr
><tr
id=sl_svn82_158

><td class="source">                    fnOnFiltered();<br></td></tr
><tr
id=sl_svn82_159

><td class="source">                });<br></td></tr
><tr
id=sl_svn82_160

><td class="source">            }<br></td></tr
><tr
id=sl_svn82_161

><td class="source"><br></td></tr
><tr
id=sl_svn82_162

><td class="source">            input.focus(function () {<br></td></tr
><tr
id=sl_svn82_163

><td class="source">                if ($(this).hasClass(&quot;search_init&quot;)) {<br></td></tr
><tr
id=sl_svn82_164

><td class="source">                    $(this).removeClass(&quot;search_init&quot;);<br></td></tr
><tr
id=sl_svn82_165

><td class="source">                    this.value = &quot;&quot;;<br></td></tr
><tr
id=sl_svn82_166

><td class="source">                }<br></td></tr
><tr
id=sl_svn82_167

><td class="source">            });<br></td></tr
><tr
id=sl_svn82_168

><td class="source">            input.blur(function () {<br></td></tr
><tr
id=sl_svn82_169

><td class="source">                if (this.value == &quot;&quot;) {<br></td></tr
><tr
id=sl_svn82_170

><td class="source">                    $(this).addClass(&quot;search_init&quot;);<br></td></tr
><tr
id=sl_svn82_171

><td class="source">                    this.value = asInitVals[index];<br></td></tr
><tr
id=sl_svn82_172

><td class="source">                }<br></td></tr
><tr
id=sl_svn82_173

><td class="source">            });<br></td></tr
><tr
id=sl_svn82_174

><td class="source">        }<br></td></tr
><tr
id=sl_svn82_175

><td class="source"><br></td></tr
><tr
id=sl_svn82_176

><td class="source">        function fnCreateRangeInput(oTable) {<br></td></tr
><tr
id=sl_svn82_177

><td class="source"><br></td></tr
><tr
id=sl_svn82_178

><td class="source">			//var currentFilter = oTable.fnSettings().aoPreSearchCols[i].sSearch;<br></td></tr
><tr
id=sl_svn82_179

><td class="source">            th.html(_fnRangeLabelPart(0));<br></td></tr
><tr
id=sl_svn82_180

><td class="source">            var sFromId = oTable.attr(&quot;id&quot;) + &#39;_range_from_&#39; + i;<br></td></tr
><tr
id=sl_svn82_181

><td class="source">            var from = $(&#39;&lt;input type=&quot;text&quot; class=&quot;number_range_filter form-control&quot; id=&quot;&#39; + sFromId + &#39;&quot; rel=&quot;&#39; + i + &#39;&quot;/&gt;&#39;);<br></td></tr
><tr
id=sl_svn82_182

><td class="source">            th.append(from);<br></td></tr
><tr
id=sl_svn82_183

><td class="source">            th.append(_fnRangeLabelPart(1));<br></td></tr
><tr
id=sl_svn82_184

><td class="source">            var sToId = oTable.attr(&quot;id&quot;) + &#39;_range_to_&#39; + i;<br></td></tr
><tr
id=sl_svn82_185

><td class="source">            var to = $(&#39;&lt;input type=&quot;text&quot; class=&quot;number_range_filter form-control&quot; id=&quot;&#39; + sToId + &#39;&quot; rel=&quot;&#39; + i + &#39;&quot;/&gt;&#39;);<br></td></tr
><tr
id=sl_svn82_186

><td class="source">            th.append(to);<br></td></tr
><tr
id=sl_svn82_187

><td class="source">            th.append(_fnRangeLabelPart(2));<br></td></tr
><tr
id=sl_svn82_188

><td class="source">            th.wrapInner(&#39;&lt;span class=&quot;filter_column filter_number_range form-control&quot; /&gt;&#39;);<br></td></tr
><tr
id=sl_svn82_189

><td class="source">            var index = i;<br></td></tr
><tr
id=sl_svn82_190

><td class="source">            aiCustomSearch_Indexes.push(i);<br></td></tr
><tr
id=sl_svn82_191

><td class="source"><br></td></tr
><tr
id=sl_svn82_192

><td class="source"><br></td></tr
><tr
id=sl_svn82_193

><td class="source"><br></td></tr
><tr
id=sl_svn82_194

><td class="source">            //------------start range filtering function<br></td></tr
><tr
id=sl_svn82_195

><td class="source"><br></td></tr
><tr
id=sl_svn82_196

><td class="source"><br></td></tr
><tr
id=sl_svn82_197

><td class="source">            /* 	Custom filtering function which will filter data in column four between two values<br></td></tr
><tr
id=sl_svn82_198

><td class="source">            *	Author: 	Allan Jardine, Modified by Jovan Popovic<br></td></tr
><tr
id=sl_svn82_199

><td class="source">            */<br></td></tr
><tr
id=sl_svn82_200

><td class="source">            //$.fn.dataTableExt.afnFiltering.push(<br></td></tr
><tr
id=sl_svn82_201

><td class="source">            oTable.dataTableExt.afnFiltering.push(<br></td></tr
><tr
id=sl_svn82_202

><td class="source">	        function (oSettings, aData, iDataIndex) {<br></td></tr
><tr
id=sl_svn82_203

><td class="source">	            if (oTable.attr(&quot;id&quot;) != oSettings.sTableId)<br></td></tr
><tr
id=sl_svn82_204

><td class="source">	                return true;<br></td></tr
><tr
id=sl_svn82_205

><td class="source">	            // Try to handle missing nodes more gracefully<br></td></tr
><tr
id=sl_svn82_206

><td class="source">	            if (document.getElementById(sFromId) == null)<br></td></tr
><tr
id=sl_svn82_207

><td class="source">	                return true;<br></td></tr
><tr
id=sl_svn82_208

><td class="source">	            var iMin = document.getElementById(sFromId).value * 1;<br></td></tr
><tr
id=sl_svn82_209

><td class="source">	            var iMax = document.getElementById(sToId).value * 1;<br></td></tr
><tr
id=sl_svn82_210

><td class="source">	            var iValue = aData[_fnColumnIndex(index)] == &quot;-&quot; ? 0 : aData[_fnColumnIndex(index)] * 1;<br></td></tr
><tr
id=sl_svn82_211

><td class="source">	            if (iMin == &quot;&quot; &amp;&amp; iMax == &quot;&quot;) {<br></td></tr
><tr
id=sl_svn82_212

><td class="source">	                return true;<br></td></tr
><tr
id=sl_svn82_213

><td class="source">	            }<br></td></tr
><tr
id=sl_svn82_214

><td class="source">	            else if (iMin == &quot;&quot; &amp;&amp; iValue &lt;= iMax) {<br></td></tr
><tr
id=sl_svn82_215

><td class="source">	                return true;<br></td></tr
><tr
id=sl_svn82_216

><td class="source">	            }<br></td></tr
><tr
id=sl_svn82_217

><td class="source">	            else if (iMin &lt;= iValue &amp;&amp; &quot;&quot; == iMax) {<br></td></tr
><tr
id=sl_svn82_218

><td class="source">	                return true;<br></td></tr
><tr
id=sl_svn82_219

><td class="source">	            }<br></td></tr
><tr
id=sl_svn82_220

><td class="source">	            else if (iMin &lt;= iValue &amp;&amp; iValue &lt;= iMax) {<br></td></tr
><tr
id=sl_svn82_221

><td class="source">	                return true;<br></td></tr
><tr
id=sl_svn82_222

><td class="source">	            }<br></td></tr
><tr
id=sl_svn82_223

><td class="source">	            return false;<br></td></tr
><tr
id=sl_svn82_224

><td class="source">	        }<br></td></tr
><tr
id=sl_svn82_225

><td class="source">        );<br></td></tr
><tr
id=sl_svn82_226

><td class="source">            //------------end range filtering function<br></td></tr
><tr
id=sl_svn82_227

><td class="source"><br></td></tr
><tr
id=sl_svn82_228

><td class="source"><br></td></tr
><tr
id=sl_svn82_229

><td class="source"><br></td></tr
><tr
id=sl_svn82_230

><td class="source">            $(&#39;#&#39; + sFromId + &#39;,#&#39; + sToId, th).keyup(function () {<br></td></tr
><tr
id=sl_svn82_231

><td class="source"><br></td></tr
><tr
id=sl_svn82_232

><td class="source">                var iMin = document.getElementById(sFromId).value * 1;<br></td></tr
><tr
id=sl_svn82_233

><td class="source">                var iMax = document.getElementById(sToId).value * 1;<br></td></tr
><tr
id=sl_svn82_234

><td class="source">                if (iMin != 0 &amp;&amp; iMax != 0 &amp;&amp; iMin &gt; iMax)<br></td></tr
><tr
id=sl_svn82_235

><td class="source">                    return;<br></td></tr
><tr
id=sl_svn82_236

><td class="source"><br></td></tr
><tr
id=sl_svn82_237

><td class="source">                oTable.fnDraw();<br></td></tr
><tr
id=sl_svn82_238

><td class="source">                fnOnFiltered();<br></td></tr
><tr
id=sl_svn82_239

><td class="source">            });<br></td></tr
><tr
id=sl_svn82_240

><td class="source"><br></td></tr
><tr
id=sl_svn82_241

><td class="source"><br></td></tr
><tr
id=sl_svn82_242

><td class="source">        }<br></td></tr
><tr
id=sl_svn82_243

><td class="source"><br></td></tr
><tr
id=sl_svn82_244

><td class="source"><br></td></tr
><tr
id=sl_svn82_245

><td class="source">        function fnCreateDateRangeInput(oTable) {<br></td></tr
><tr
id=sl_svn82_246

><td class="source"><br></td></tr
><tr
id=sl_svn82_247

><td class="source">            var aoFragments = sRangeFormat.split(/[}{]/);<br></td></tr
><tr
id=sl_svn82_248

><td class="source"><br></td></tr
><tr
id=sl_svn82_249

><td class="source">            th.html(&quot;&quot;);<br></td></tr
><tr
id=sl_svn82_250

><td class="source">            //th.html(_fnRangeLabelPart(0));<br></td></tr
><tr
id=sl_svn82_251

><td class="source">            var sFromId = oTable.attr(&quot;id&quot;) + &#39;_range_from_&#39; + i;<br></td></tr
><tr
id=sl_svn82_252

><td class="source">            var from = $(&#39;&lt;input type=&quot;text&quot; class=&quot;date_range_filter form-control&quot; id=&quot;&#39; + sFromId + &#39;&quot; rel=&quot;&#39; + i + &#39;&quot;/&gt;&#39;);<br></td></tr
><tr
id=sl_svn82_253

><td class="source">            from.datepicker();<br></td></tr
><tr
id=sl_svn82_254

><td class="source">            //th.append(from);<br></td></tr
><tr
id=sl_svn82_255

><td class="source">            //th.append(_fnRangeLabelPart(1));<br></td></tr
><tr
id=sl_svn82_256

><td class="source">            var sToId = oTable.attr(&quot;id&quot;) + &#39;_range_to_&#39; + i;<br></td></tr
><tr
id=sl_svn82_257

><td class="source">            var to = $(&#39;&lt;input type=&quot;text&quot; class=&quot;date_range_filter form-control&quot; id=&quot;&#39; + sToId + &#39;&quot; rel=&quot;&#39; + i + &#39;&quot;/&gt;&#39;);<br></td></tr
><tr
id=sl_svn82_258

><td class="source">            //th.append(to);<br></td></tr
><tr
id=sl_svn82_259

><td class="source">            //th.append(_fnRangeLabelPart(2));<br></td></tr
><tr
id=sl_svn82_260

><td class="source"><br></td></tr
><tr
id=sl_svn82_261

><td class="source">            for (ti = 0; ti &lt; aoFragments.length; ti++) {<br></td></tr
><tr
id=sl_svn82_262

><td class="source"><br></td></tr
><tr
id=sl_svn82_263

><td class="source">                if (aoFragments[ti] == properties.sDateFromToken) {<br></td></tr
><tr
id=sl_svn82_264

><td class="source">                    th.append(from);<br></td></tr
><tr
id=sl_svn82_265

><td class="source">                } else {<br></td></tr
><tr
id=sl_svn82_266

><td class="source">                    if (aoFragments[ti] == properties.sDateToToken) {<br></td></tr
><tr
id=sl_svn82_267

><td class="source">                        th.append(to);<br></td></tr
><tr
id=sl_svn82_268

><td class="source">                    } else {<br></td></tr
><tr
id=sl_svn82_269

><td class="source">                        th.append(aoFragments[ti]);<br></td></tr
><tr
id=sl_svn82_270

><td class="source">                    }<br></td></tr
><tr
id=sl_svn82_271

><td class="source">                }<br></td></tr
><tr
id=sl_svn82_272

><td class="source">                <br></td></tr
><tr
id=sl_svn82_273

><td class="source"><br></td></tr
><tr
id=sl_svn82_274

><td class="source">            }<br></td></tr
><tr
id=sl_svn82_275

><td class="source"><br></td></tr
><tr
id=sl_svn82_276

><td class="source"><br></td></tr
><tr
id=sl_svn82_277

><td class="source">            th.wrapInner(&#39;&lt;span class=&quot;filter_column filter_date_range&quot; /&gt;&#39;);<br></td></tr
><tr
id=sl_svn82_278

><td class="source">            to.datepicker();<br></td></tr
><tr
id=sl_svn82_279

><td class="source">            var index = i;<br></td></tr
><tr
id=sl_svn82_280

><td class="source">            aiCustomSearch_Indexes.push(i);<br></td></tr
><tr
id=sl_svn82_281

><td class="source"><br></td></tr
><tr
id=sl_svn82_282

><td class="source"><br></td></tr
><tr
id=sl_svn82_283

><td class="source">            //------------start date range filtering function<br></td></tr
><tr
id=sl_svn82_284

><td class="source"><br></td></tr
><tr
id=sl_svn82_285

><td class="source">            //$.fn.dataTableExt.afnFiltering.push(<br></td></tr
><tr
id=sl_svn82_286

><td class="source">            oTable.dataTableExt.afnFiltering.push(<br></td></tr
><tr
id=sl_svn82_287

><td class="source">	        function (oSettings, aData, iDataIndex) {<br></td></tr
><tr
id=sl_svn82_288

><td class="source">	            if (oTable.attr(&quot;id&quot;) != oSettings.sTableId)<br></td></tr
><tr
id=sl_svn82_289

><td class="source">	                return true;<br></td></tr
><tr
id=sl_svn82_290

><td class="source"><br></td></tr
><tr
id=sl_svn82_291

><td class="source">	            var dStartDate = from.datepicker(&quot;getDate&quot;);<br></td></tr
><tr
id=sl_svn82_292

><td class="source"><br></td></tr
><tr
id=sl_svn82_293

><td class="source">	            var dEndDate = to.datepicker(&quot;getDate&quot;);<br></td></tr
><tr
id=sl_svn82_294

><td class="source"><br></td></tr
><tr
id=sl_svn82_295

><td class="source">	            if (dStartDate == null &amp;&amp; dEndDate == null) {<br></td></tr
><tr
id=sl_svn82_296

><td class="source">	                return true;<br></td></tr
><tr
id=sl_svn82_297

><td class="source">	            }<br></td></tr
><tr
id=sl_svn82_298

><td class="source"><br></td></tr
><tr
id=sl_svn82_299

><td class="source">	            var dCellDate = null;<br></td></tr
><tr
id=sl_svn82_300

><td class="source">	            try {<br></td></tr
><tr
id=sl_svn82_301

><td class="source">	                if (aData[_fnColumnIndex(index)] == null || aData[_fnColumnIndex(index)] == &quot;&quot;)<br></td></tr
><tr
id=sl_svn82_302

><td class="source">	                    return false;<br></td></tr
><tr
id=sl_svn82_303

><td class="source">	                dCellDate = $.datepicker.parseDate($.datepicker.regional[&quot;&quot;].dateFormat, aData[_fnColumnIndex(index)]);<br></td></tr
><tr
id=sl_svn82_304

><td class="source">	            } catch (ex) {<br></td></tr
><tr
id=sl_svn82_305

><td class="source">	                return false;<br></td></tr
><tr
id=sl_svn82_306

><td class="source">	            }<br></td></tr
><tr
id=sl_svn82_307

><td class="source">	            if (dCellDate == null)<br></td></tr
><tr
id=sl_svn82_308

><td class="source">	                return false;<br></td></tr
><tr
id=sl_svn82_309

><td class="source"><br></td></tr
><tr
id=sl_svn82_310

><td class="source"><br></td></tr
><tr
id=sl_svn82_311

><td class="source">	            if (dStartDate == null &amp;&amp; dCellDate &lt;= dEndDate) {<br></td></tr
><tr
id=sl_svn82_312

><td class="source">	                return true;<br></td></tr
><tr
id=sl_svn82_313

><td class="source">	            }<br></td></tr
><tr
id=sl_svn82_314

><td class="source">	            else if (dStartDate &lt;= dCellDate &amp;&amp; dEndDate == null) {<br></td></tr
><tr
id=sl_svn82_315

><td class="source">	                return true;<br></td></tr
><tr
id=sl_svn82_316

><td class="source">	            }<br></td></tr
><tr
id=sl_svn82_317

><td class="source">	            else if (dStartDate &lt;= dCellDate &amp;&amp; dCellDate &lt;= dEndDate) {<br></td></tr
><tr
id=sl_svn82_318

><td class="source">	                return true;<br></td></tr
><tr
id=sl_svn82_319

><td class="source">	            }<br></td></tr
><tr
id=sl_svn82_320

><td class="source">	            return false;<br></td></tr
><tr
id=sl_svn82_321

><td class="source">	        }<br></td></tr
><tr
id=sl_svn82_322

><td class="source">        );<br></td></tr
><tr
id=sl_svn82_323

><td class="source">            //------------end date range filtering function<br></td></tr
><tr
id=sl_svn82_324

><td class="source"><br></td></tr
><tr
id=sl_svn82_325

><td class="source">            $(&#39;#&#39; + sFromId + &#39;,#&#39; + sToId, th).change(function () {<br></td></tr
><tr
id=sl_svn82_326

><td class="source">                oTable.fnDraw();<br></td></tr
><tr
id=sl_svn82_327

><td class="source">                fnOnFiltered();<br></td></tr
><tr
id=sl_svn82_328

><td class="source">            });<br></td></tr
><tr
id=sl_svn82_329

><td class="source"><br></td></tr
><tr
id=sl_svn82_330

><td class="source"><br></td></tr
><tr
id=sl_svn82_331

><td class="source">        }<br></td></tr
><tr
id=sl_svn82_332

><td class="source"><br></td></tr
><tr
id=sl_svn82_333

><td class="source">        function fnCreateColumnSelect(oTable, aData, iColumn, nTh, sLabel, bRegex, oSelected, bMultiselect) {<br></td></tr
><tr
id=sl_svn82_334

><td class="source">            if (aData == null)<br></td></tr
><tr
id=sl_svn82_335

><td class="source">                aData = _fnGetColumnValues(oTable.fnSettings(), iColumn, true, false, true);<br></td></tr
><tr
id=sl_svn82_336

><td class="source">            var index = iColumn;<br></td></tr
><tr
id=sl_svn82_337

><td class="source">            var currentFilter = oTable.fnSettings().aoPreSearchCols[i].sSearch;<br></td></tr
><tr
id=sl_svn82_338

><td class="source">            if (currentFilter == null || currentFilter == &quot;&quot;)//Issue 81<br></td></tr
><tr
id=sl_svn82_339

><td class="source">                currentFilter = oSelected;<br></td></tr
><tr
id=sl_svn82_340

><td class="source"><br></td></tr
><tr
id=sl_svn82_341

><td class="source">            var r = &#39;&lt;select class=&quot;search_init select_filter form-control&quot; rel=&quot;&#39; + i + &#39;&quot;&gt;&lt;option value=&quot;&quot; class=&quot;search_init&quot;&gt;&#39; + sLabel + &#39;&lt;/option&gt;&#39;;<br></td></tr
><tr
id=sl_svn82_342

><td class="source">			if(bMultiselect) {<br></td></tr
><tr
id=sl_svn82_343

><td class="source">				r = &#39;&lt;select class=&quot;search_init select_filter form-control&quot; rel=&quot;&#39; + i + &#39;&quot; multiple&gt;&#39;;<br></td></tr
><tr
id=sl_svn82_344

><td class="source">			}<br></td></tr
><tr
id=sl_svn82_345

><td class="source">            var j = 0;<br></td></tr
><tr
id=sl_svn82_346

><td class="source">            var iLen = aData.length;<br></td></tr
><tr
id=sl_svn82_347

><td class="source">            for (j = 0; j &lt; iLen; j++) {<br></td></tr
><tr
id=sl_svn82_348

><td class="source">                if (typeof (aData[j]) != &#39;object&#39;) {<br></td></tr
><tr
id=sl_svn82_349

><td class="source">                    var selected = &#39;&#39;;<br></td></tr
><tr
id=sl_svn82_350

><td class="source">                    if (escape(aData[j]) == currentFilter<br></td></tr
><tr
id=sl_svn82_351

><td class="source">                        || escape(aData[j]) == escape(currentFilter)<br></td></tr
><tr
id=sl_svn82_352

><td class="source">                        )<br></td></tr
><tr
id=sl_svn82_353

><td class="source">                        selected = &#39;selected &#39;<br></td></tr
><tr
id=sl_svn82_354

><td class="source">                    r += &#39;&lt;option &#39; + selected + &#39; value=&quot;&#39; + escape(aData[j]) + &#39;&quot;&gt;&#39; + aData[j] + &#39;&lt;/option&gt;&#39;;<br></td></tr
><tr
id=sl_svn82_355

><td class="source">                }<br></td></tr
><tr
id=sl_svn82_356

><td class="source">                else {<br></td></tr
><tr
id=sl_svn82_357

><td class="source">                    var selected = &#39;&#39;;<br></td></tr
><tr
id=sl_svn82_358

><td class="source">                    if (bRegex) {<br></td></tr
><tr
id=sl_svn82_359

><td class="source">                        //Do not escape values if they are explicitely set to avoid escaping special characters in the regexp<br></td></tr
><tr
id=sl_svn82_360

><td class="source">                        if (aData[j].value == currentFilter) selected = &#39;selected &#39;;<br></td></tr
><tr
id=sl_svn82_361

><td class="source">                        r += &#39;&lt;option &#39; + selected + &#39;value=&quot;&#39; + aData[j].value + &#39;&quot;&gt;&#39; + aData[j].label + &#39;&lt;/option&gt;&#39;;<br></td></tr
><tr
id=sl_svn82_362

><td class="source">                    } else {<br></td></tr
><tr
id=sl_svn82_363

><td class="source">                        if (escape(aData[j].value) == currentFilter) selected = &#39;selected &#39;;<br></td></tr
><tr
id=sl_svn82_364

><td class="source">                        r += &#39;&lt;option &#39; + selected + &#39;value=&quot;&#39; + escape(aData[j].value) + &#39;&quot;&gt;&#39; + aData[j].label + &#39;&lt;/option&gt;&#39;;<br></td></tr
><tr
id=sl_svn82_365

><td class="source">                    }<br></td></tr
><tr
id=sl_svn82_366

><td class="source">                }<br></td></tr
><tr
id=sl_svn82_367

><td class="source">            }<br></td></tr
><tr
id=sl_svn82_368

><td class="source"><br></td></tr
><tr
id=sl_svn82_369

><td class="source">            var select = $(r + &#39;&lt;/select&gt;&#39;);<br></td></tr
><tr
id=sl_svn82_370

><td class="source">            nTh.html(select);<br></td></tr
><tr
id=sl_svn82_371

><td class="source">            nTh.wrapInner(&#39;&lt;span class=&quot;filter_column filter_select&quot; /&gt;&#39;);<br></td></tr
><tr
id=sl_svn82_372

><td class="source">			<br></td></tr
><tr
id=sl_svn82_373

><td class="source">			if(bMultiselect) {<br></td></tr
><tr
id=sl_svn82_374

><td class="source">				select.change(function () {<br></td></tr
><tr
id=sl_svn82_375

><td class="source">					if ($(this).val() != &quot;&quot;) {<br></td></tr
><tr
id=sl_svn82_376

><td class="source">						$(this).removeClass(&quot;search_init&quot;);<br></td></tr
><tr
id=sl_svn82_377

><td class="source">					} else {<br></td></tr
><tr
id=sl_svn82_378

><td class="source">						$(this).addClass(&quot;search_init&quot;);<br></td></tr
><tr
id=sl_svn82_379

><td class="source">					}<br></td></tr
><tr
id=sl_svn82_380

><td class="source">					var selectedOptions = $(this).val();<br></td></tr
><tr
id=sl_svn82_381

><td class="source">					var asEscapedFilters = [];<br></td></tr
><tr
id=sl_svn82_382

><td class="source">					if(selectedOptions==null || selectedOptions==[]){<br></td></tr
><tr
id=sl_svn82_383

><td class="source">						var re = &#39;^(.*)$&#39;;<br></td></tr
><tr
id=sl_svn82_384

><td class="source">					}else{<br></td></tr
><tr
id=sl_svn82_385

><td class="source">						$.each( selectedOptions, function( i, sFilter ) {<br></td></tr
><tr
id=sl_svn82_386

><td class="source">							asEscapedFilters.push( fnRegExpEscape( sFilter ) );<br></td></tr
><tr
id=sl_svn82_387

><td class="source">						} );<br></td></tr
><tr
id=sl_svn82_388

><td class="source">						var re = &#39;^(&#39; + asEscapedFilters.join(&#39;|&#39;) + &#39;)$&#39;;<br></td></tr
><tr
id=sl_svn82_389

><td class="source">					}<br></td></tr
><tr
id=sl_svn82_390

><td class="source">					 <br></td></tr
><tr
id=sl_svn82_391

><td class="source">					oTable.fnFilter( re, index, true, false );<br></td></tr
><tr
id=sl_svn82_392

><td class="source">				});<br></td></tr
><tr
id=sl_svn82_393

><td class="source">			} else {<br></td></tr
><tr
id=sl_svn82_394

><td class="source">				select.change(function () {<br></td></tr
><tr
id=sl_svn82_395

><td class="source">					//var val = $(this).val();<br></td></tr
><tr
id=sl_svn82_396

><td class="source">					if ($(this).val() != &quot;&quot;) {<br></td></tr
><tr
id=sl_svn82_397

><td class="source">						$(this).removeClass(&quot;search_init&quot;);<br></td></tr
><tr
id=sl_svn82_398

><td class="source">					} else {<br></td></tr
><tr
id=sl_svn82_399

><td class="source">						$(this).addClass(&quot;search_init&quot;);<br></td></tr
><tr
id=sl_svn82_400

><td class="source">					}<br></td></tr
><tr
id=sl_svn82_401

><td class="source">					if (bRegex)<br></td></tr
><tr
id=sl_svn82_402

><td class="source">						oTable.fnFilter($(this).val(), iColumn, bRegex); //Issue 41<br></td></tr
><tr
id=sl_svn82_403

><td class="source">					else<br></td></tr
><tr
id=sl_svn82_404

><td class="source">						oTable.fnFilter(unescape($(this).val()), iColumn); //Issue 25<br></td></tr
><tr
id=sl_svn82_405

><td class="source">					fnOnFiltered();<br></td></tr
><tr
id=sl_svn82_406

><td class="source">				});<br></td></tr
><tr
id=sl_svn82_407

><td class="source">				if (currentFilter != null &amp;&amp; currentFilter != &quot;&quot;)//Issue 81<br></td></tr
><tr
id=sl_svn82_408

><td class="source">					oTable.fnFilter(unescape(currentFilter), iColumn);<br></td></tr
><tr
id=sl_svn82_409

><td class="source">			}<br></td></tr
><tr
id=sl_svn82_410

><td class="source">        }<br></td></tr
><tr
id=sl_svn82_411

><td class="source"><br></td></tr
><tr
id=sl_svn82_412

><td class="source">        function fnCreateSelect(oTable, aData, bRegex, oSelected, bMultiselect) {<br></td></tr
><tr
id=sl_svn82_413

><td class="source">            var oSettings = oTable.fnSettings();<br></td></tr
><tr
id=sl_svn82_414

><td class="source">            if ( (aData == null || typeof(aData) == &#39;function&#39; ) &amp;&amp; oSettings.sAjaxSource != &quot;&quot; &amp;&amp; !oSettings.oFeatures.bServerSide) {<br></td></tr
><tr
id=sl_svn82_415

><td class="source">                // Add a function to the draw callback, which will check for the Ajax data having <br></td></tr
><tr
id=sl_svn82_416

><td class="source">                // been loaded. Use a closure for the individual column elements that are used to <br></td></tr
><tr
id=sl_svn82_417

><td class="source">                // built the column filter, since &#39;i&#39; and &#39;th&#39; (etc) are locally &quot;global&quot;.<br></td></tr
><tr
id=sl_svn82_418

><td class="source">                oSettings.aoDrawCallback.push({<br></td></tr
><tr
id=sl_svn82_419

><td class="source">                    &quot;fn&quot;: (function (iColumn, nTh, sLabel) {<br></td></tr
><tr
id=sl_svn82_420

><td class="source">                        return function (oSettings) {<br></td></tr
><tr
id=sl_svn82_421

><td class="source">                            // Only rebuild the select on the second draw - i.e. when the Ajax<br></td></tr
><tr
id=sl_svn82_422

><td class="source">                            // data has been loaded.<br></td></tr
><tr
id=sl_svn82_423

><td class="source">                            if (oSettings.iDraw == 2 &amp;&amp; oSettings.sAjaxSource != null &amp;&amp; oSettings.sAjaxSource != &quot;&quot; &amp;&amp; !oSettings.oFeatures.bServerSide) {<br></td></tr
><tr
id=sl_svn82_424

><td class="source">                                return fnCreateColumnSelect(oTable, aData &amp;&amp; aData(oSettings.aoData, oSettings), _fnColumnIndex(iColumn), nTh, sLabel, bRegex, oSelected, bMultiselect); //Issue 37<br></td></tr
><tr
id=sl_svn82_425

><td class="source">                            }<br></td></tr
><tr
id=sl_svn82_426

><td class="source">                        };<br></td></tr
><tr
id=sl_svn82_427

><td class="source">                    })(i, th, label),<br></td></tr
><tr
id=sl_svn82_428

><td class="source">                    &quot;sName&quot;: &quot;column_filter_&quot; + i<br></td></tr
><tr
id=sl_svn82_429

><td class="source">                });<br></td></tr
><tr
id=sl_svn82_430

><td class="source">            }<br></td></tr
><tr
id=sl_svn82_431

><td class="source">            // Regardless of the Ajax state, build the select on first pass<br></td></tr
><tr
id=sl_svn82_432

><td class="source">            fnCreateColumnSelect(oTable, typeof(aData) == &#39;function&#39; ? null: aData, _fnColumnIndex(i), th, label, bRegex, oSelected, bMultiselect); //Issue 37<br></td></tr
><tr
id=sl_svn82_433

><td class="source"><br></td></tr
><tr
id=sl_svn82_434

><td class="source">        }<br></td></tr
><tr
id=sl_svn82_435

><td class="source">		 <br></td></tr
><tr
id=sl_svn82_436

><td class="source">		function fnRegExpEscape( sText ) { <br></td></tr
><tr
id=sl_svn82_437

><td class="source">			return sText.replace(/[-[\]{}()*+?.,\\^$|#\s]/g, &quot;\\$&amp;&quot;); <br></td></tr
><tr
id=sl_svn82_438

><td class="source">		};<br></td></tr
><tr
id=sl_svn82_439

><td class="source"><br></td></tr
><tr
id=sl_svn82_440

><td class="source">		function fnCreateDropdown(aData) {<br></td></tr
><tr
id=sl_svn82_441

><td class="source">			var index = i;<br></td></tr
><tr
id=sl_svn82_442

><td class="source">			var r = &#39;&lt;div class=&quot;dropdown select_filter form-control&quot;&gt;&lt;a class=&quot;dropdown-toggle&quot; data-toggle=&quot;dropdown&quot; href=&quot;#&quot;&gt;&#39; + label + &#39;&lt;b class=&quot;caret&quot;&gt;&lt;/b&gt;&lt;/a&gt;&lt;ul class=&quot;dropdown-menu&quot; role=&quot;menu&quot;&gt;&lt;li data-value=&quot;&quot;&gt;&lt;a&gt;Show All&lt;/a&gt;&lt;/li&gt;&#39;, j, iLen = aData.length;<br></td></tr
><tr
id=sl_svn82_443

><td class="source"><br></td></tr
><tr
id=sl_svn82_444

><td class="source">			for (j = 0; j &lt; iLen; j++) {<br></td></tr
><tr
id=sl_svn82_445

><td class="source">				r += &#39;&lt;li data-value=&quot;&#39; + aData[j] + &#39;&quot;&gt;&lt;a&gt;&#39; + aData[j] + &#39;&lt;/a&gt;&lt;/li&gt;&#39;;<br></td></tr
><tr
id=sl_svn82_446

><td class="source">			}<br></td></tr
><tr
id=sl_svn82_447

><td class="source">			var select = $(r + &#39;&lt;/ul&gt;&lt;/div&gt;&#39;);<br></td></tr
><tr
id=sl_svn82_448

><td class="source">			th.html(select);<br></td></tr
><tr
id=sl_svn82_449

><td class="source">			th.wrapInner(&#39;&lt;span class=&quot;filterColumn filter_select&quot; /&gt;&#39;);<br></td></tr
><tr
id=sl_svn82_450

><td class="source">			select.find(&#39;li&#39;).click(function () {<br></td></tr
><tr
id=sl_svn82_451

><td class="source">				oTable.fnFilter($(this).data(&#39;value&#39;), index);<br></td></tr
><tr
id=sl_svn82_452

><td class="source">			});<br></td></tr
><tr
id=sl_svn82_453

><td class="source">		}<br></td></tr
><tr
id=sl_svn82_454

><td class="source">		<br></td></tr
><tr
id=sl_svn82_455

><td class="source">		<br></td></tr
><tr
id=sl_svn82_456

><td class="source">        function fnCreateCheckbox(oTable, aData) {<br></td></tr
><tr
id=sl_svn82_457

><td class="source"><br></td></tr
><tr
id=sl_svn82_458

><td class="source">            if (aData == null)<br></td></tr
><tr
id=sl_svn82_459

><td class="source">                aData = _fnGetColumnValues(oTable.fnSettings(), i, true, true, true);<br></td></tr
><tr
id=sl_svn82_460

><td class="source">            var index = i;<br></td></tr
><tr
id=sl_svn82_461

><td class="source"><br></td></tr
><tr
id=sl_svn82_462

><td class="source">            var r = &#39;&#39;, j, iLen = aData.length;<br></td></tr
><tr
id=sl_svn82_463

><td class="source"><br></td></tr
><tr
id=sl_svn82_464

><td class="source">            //clean the string<br></td></tr
><tr
id=sl_svn82_465

><td class="source">            var localLabel = label.replace(&#39;%&#39;, &#39;Perc&#39;).replace(&quot;&amp;&quot;, &quot;AND&quot;).replace(&quot;$&quot;, &quot;DOL&quot;).replace(&quot;£&quot;, &quot;STERL&quot;).replace(&quot;@&quot;, &quot;AT&quot;).replace(/\s/g, &quot;_&quot;);<br></td></tr
><tr
id=sl_svn82_466

><td class="source">            localLabel = localLabel.replace(/[^a-zA-Z 0-9]+/g, &#39;&#39;);<br></td></tr
><tr
id=sl_svn82_467

><td class="source">            //clean the string<br></td></tr
><tr
id=sl_svn82_468

><td class="source"><br></td></tr
><tr
id=sl_svn82_469

><td class="source">            //button label override<br></td></tr
><tr
id=sl_svn82_470

><td class="source">            var labelBtn = label;<br></td></tr
><tr
id=sl_svn82_471

><td class="source">            if (properties.sFilterButtonText != null || properties.sFilterButtonText != undefined) {<br></td></tr
><tr
id=sl_svn82_472

><td class="source">                labelBtn = properties.sFilterButtonText;<br></td></tr
><tr
id=sl_svn82_473

><td class="source">            }<br></td></tr
><tr
id=sl_svn82_474

><td class="source"><br></td></tr
><tr
id=sl_svn82_475

><td class="source">            var relativeDivWidthToggleSize = 10;<br></td></tr
><tr
id=sl_svn82_476

><td class="source">            var numRow = 12; //numero di checkbox per colonna<br></td></tr
><tr
id=sl_svn82_477

><td class="source">            var numCol = Math.floor(iLen / numRow);<br></td></tr
><tr
id=sl_svn82_478

><td class="source">            if (iLen % numRow &gt; 0) {<br></td></tr
><tr
id=sl_svn82_479

><td class="source">                numCol = numCol + 1;<br></td></tr
><tr
id=sl_svn82_480

><td class="source">            };<br></td></tr
><tr
id=sl_svn82_481

><td class="source"><br></td></tr
><tr
id=sl_svn82_482

><td class="source">            //count how many column should be generated and split the div size<br></td></tr
><tr
id=sl_svn82_483

><td class="source">            var divWidth = 100 / numCol - 2;<br></td></tr
><tr
id=sl_svn82_484

><td class="source"><br></td></tr
><tr
id=sl_svn82_485

><td class="source">            var divWidthToggle = relativeDivWidthToggleSize * numCol;<br></td></tr
><tr
id=sl_svn82_486

><td class="source"><br></td></tr
><tr
id=sl_svn82_487

><td class="source">            if (numCol == 1) {<br></td></tr
><tr
id=sl_svn82_488

><td class="source">                divWidth = 20;<br></td></tr
><tr
id=sl_svn82_489

><td class="source">            }<br></td></tr
><tr
id=sl_svn82_490

><td class="source"><br></td></tr
><tr
id=sl_svn82_491

><td class="source">            var divRowDef = &#39;&lt;div style=&quot;float:left; min-width: &#39; + divWidth + &#39;%; &quot; &gt;&#39;;<br></td></tr
><tr
id=sl_svn82_492

><td class="source">            var divClose = &#39;&lt;/div&gt;&#39;;<br></td></tr
><tr
id=sl_svn82_493

><td class="source"><br></td></tr
><tr
id=sl_svn82_494

><td class="source">            var uniqueId = oTable.attr(&quot;id&quot;) + localLabel;<br></td></tr
><tr
id=sl_svn82_495

><td class="source">            var buttonId = &quot;chkBtnOpen&quot; + uniqueId;<br></td></tr
><tr
id=sl_svn82_496

><td class="source">            var checkToggleDiv = uniqueId + &quot;-flt-toggle&quot;;<br></td></tr
><tr
id=sl_svn82_497

><td class="source">            r += &#39;&lt;button id=&quot;&#39; + buttonId + &#39;&quot; class=&quot;checkbox_filter btn btn-default&quot; &gt; &#39; + labelBtn + &#39;&lt;/button&gt;&#39;; //filter button witch open dialog<br></td></tr
><tr
id=sl_svn82_498

><td class="source">            r += &#39;&lt;div id=&quot;&#39; + checkToggleDiv + &#39;&quot; &#39;<br></td></tr
><tr
id=sl_svn82_499

><td class="source">            	+ &#39;title=&quot;&#39; + label + &#39;&quot; &#39;<br></td></tr
><tr
id=sl_svn82_500

><td class="source">                + &#39;rel=&quot;&#39; + i + &#39;&quot; &#39;<br></td></tr
><tr
id=sl_svn82_501

><td class="source">            	+ &#39;class=&quot;toggle-check ui-widget-content ui-corner-all&quot;  style=&quot;width: &#39; + (divWidthToggle) + &#39;%; &quot; &gt;&#39;; //dialog div<br></td></tr
><tr
id=sl_svn82_502

><td class="source">            //r+= &#39;&lt;div align=&quot;center&quot; style=&quot;margin-top: 5px; &quot;&gt; &lt;button id=&quot;&#39;+buttonId+&#39;Reset&quot; class=&quot;checkbox_filter&quot; &gt; reset &lt;/button&gt; &lt;/div&gt;&#39;; //reset button and its div<br></td></tr
><tr
id=sl_svn82_503

><td class="source">            r += divRowDef;<br></td></tr
><tr
id=sl_svn82_504

><td class="source"><br></td></tr
><tr
id=sl_svn82_505

><td class="source">            for (j = 0; j &lt; iLen; j++) {<br></td></tr
><tr
id=sl_svn82_506

><td class="source"><br></td></tr
><tr
id=sl_svn82_507

><td class="source">                //if last check close div<br></td></tr
><tr
id=sl_svn82_508

><td class="source">                if (j % numRow == 0 &amp;&amp; j != 0) {<br></td></tr
><tr
id=sl_svn82_509

><td class="source">                    r += divClose + divRowDef;<br></td></tr
><tr
id=sl_svn82_510

><td class="source">                }<br></td></tr
><tr
id=sl_svn82_511

><td class="source"><br></td></tr
><tr
id=sl_svn82_512

><td class="source">                var sLabel = aData[j];<br></td></tr
><tr
id=sl_svn82_513

><td class="source">                var sValue = aData[j];<br></td></tr
><tr
id=sl_svn82_514

><td class="source"><br></td></tr
><tr
id=sl_svn82_515

><td class="source">                if (typeof (aData[j]) == &#39;object&#39;) {<br></td></tr
><tr
id=sl_svn82_516

><td class="source">                    sLabel = aData[j].label;<br></td></tr
><tr
id=sl_svn82_517

><td class="source">                    sValue = aData[j].value;<br></td></tr
><tr
id=sl_svn82_518

><td class="source">                }<br></td></tr
><tr
id=sl_svn82_519

><td class="source"><br></td></tr
><tr
id=sl_svn82_520

><td class="source">                //check button<br></td></tr
><tr
id=sl_svn82_521

><td class="source">                r += &#39;&lt;input class=&quot;search_init checkbox_filter btn btn-default&quot; type=&quot;checkbox&quot; id= &quot;&#39; + uniqueId + &#39;_cb_&#39; + sValue + &#39;&quot; name= &quot;&#39; + localLabel + &#39;&quot; value=&quot;&#39; + sValue + &#39;&quot; &gt;&#39; + sLabel + &#39;&lt;br/&gt;&#39;;<br></td></tr
><tr
id=sl_svn82_522

><td class="source"><br></td></tr
><tr
id=sl_svn82_523

><td class="source">                var checkbox = $(r);<br></td></tr
><tr
id=sl_svn82_524

><td class="source">                th.html(checkbox);<br></td></tr
><tr
id=sl_svn82_525

><td class="source">                th.wrapInner(&#39;&lt;span class=&quot;filter_column filter_checkbox&quot; /&gt;&#39;);<br></td></tr
><tr
id=sl_svn82_526

><td class="source">                //on every checkbox selection<br></td></tr
><tr
id=sl_svn82_527

><td class="source">                checkbox.change(function () {<br></td></tr
><tr
id=sl_svn82_528

><td class="source"><br></td></tr
><tr
id=sl_svn82_529

><td class="source">                    var search = &#39;&#39;;<br></td></tr
><tr
id=sl_svn82_530

><td class="source">                    var or = &#39;|&#39;; //var for select checks in &#39;or&#39; into the regex<br></td></tr
><tr
id=sl_svn82_531

><td class="source">                    var resSize = $(&#39;input:checkbox[name=&quot;&#39; + localLabel + &#39;&quot;]:checked&#39;).size();<br></td></tr
><tr
id=sl_svn82_532

><td class="source">                    $(&#39;input:checkbox[name=&quot;&#39; + localLabel + &#39;&quot;]:checked&#39;).each(function (index) {<br></td></tr
><tr
id=sl_svn82_533

><td class="source"><br></td></tr
><tr
id=sl_svn82_534

><td class="source">                        //search = search + &#39; &#39; + $(this).val();<br></td></tr
><tr
id=sl_svn82_535

><td class="source">                        //concatenation for selected checks in or<br></td></tr
><tr
id=sl_svn82_536

><td class="source">                        if ((index == 0 &amp;&amp; resSize == 1)<br></td></tr
><tr
id=sl_svn82_537

><td class="source">                				|| (index != 0 &amp;&amp; index == resSize - 1)) {<br></td></tr
><tr
id=sl_svn82_538

><td class="source">                            or = &#39;&#39;;<br></td></tr
><tr
id=sl_svn82_539

><td class="source">                        }<br></td></tr
><tr
id=sl_svn82_540

><td class="source">                        //trim<br></td></tr
><tr
id=sl_svn82_541

><td class="source">                        search = search.replace(/^\s+|\s+$/g, &quot;&quot;);<br></td></tr
><tr
id=sl_svn82_542

><td class="source">                        search = search + $(this).val() + or;<br></td></tr
><tr
id=sl_svn82_543

><td class="source">                        or = &#39;|&#39;;<br></td></tr
><tr
id=sl_svn82_544

><td class="source"><br></td></tr
><tr
id=sl_svn82_545

><td class="source">                    });<br></td></tr
><tr
id=sl_svn82_546

><td class="source"><br></td></tr
><tr
id=sl_svn82_547

><td class="source"><br></td></tr
><tr
id=sl_svn82_548

><td class="source">                    if (search != &quot;&quot;) {<br></td></tr
><tr
id=sl_svn82_549

><td class="source">                        $(&#39;input:checkbox[name=&quot;&#39; + localLabel + &#39;&quot;]&#39;).removeClass(&quot;search_init&quot;);<br></td></tr
><tr
id=sl_svn82_550

><td class="source">                    } else {<br></td></tr
><tr
id=sl_svn82_551

><td class="source">                        $(&#39;input:checkbox[name=&quot;&#39; + localLabel + &#39;&quot;]&#39;).addClass(&quot;search_init&quot;);<br></td></tr
><tr
id=sl_svn82_552

><td class="source">                    }<br></td></tr
><tr
id=sl_svn82_553

><td class="source">                    /* Old code for setting search_init CSS class on checkboxes if any of them is checked<br></td></tr
><tr
id=sl_svn82_554

><td class="source">                    for (var jj = 0; jj &lt; iLen; jj++) {<br></td></tr
><tr
id=sl_svn82_555

><td class="source">                        if (search != &quot;&quot;) {<br></td></tr
><tr
id=sl_svn82_556

><td class="source">                            $(&#39;#&#39; + aData[jj]).removeClass(&quot;search_init&quot;);<br></td></tr
><tr
id=sl_svn82_557

><td class="source">                        } else {<br></td></tr
><tr
id=sl_svn82_558

><td class="source">                            $(&#39;#&#39; + aData[jj]).addClass(&quot;search_init&quot;);<br></td></tr
><tr
id=sl_svn82_559

><td class="source">                        }<br></td></tr
><tr
id=sl_svn82_560

><td class="source">                    }<br></td></tr
><tr
id=sl_svn82_561

><td class="source">                    */<br></td></tr
><tr
id=sl_svn82_562

><td class="source"><br></td></tr
><tr
id=sl_svn82_563

><td class="source">                    //execute search<br></td></tr
><tr
id=sl_svn82_564

><td class="source">                    oTable.fnFilter(search, index, true, false);<br></td></tr
><tr
id=sl_svn82_565

><td class="source">                    fnOnFiltered();<br></td></tr
><tr
id=sl_svn82_566

><td class="source">                });<br></td></tr
><tr
id=sl_svn82_567

><td class="source">            }<br></td></tr
><tr
id=sl_svn82_568

><td class="source"><br></td></tr
><tr
id=sl_svn82_569

><td class="source">            //filter button<br></td></tr
><tr
id=sl_svn82_570

><td class="source">            $(&#39;#&#39; + buttonId).button();<br></td></tr
><tr
id=sl_svn82_571

><td class="source">            //dialog<br></td></tr
><tr
id=sl_svn82_572

><td class="source">            $(&#39;#&#39; + checkToggleDiv).dialog({<br></td></tr
><tr
id=sl_svn82_573

><td class="source">                //height: 140,<br></td></tr
><tr
id=sl_svn82_574

><td class="source">                autoOpen: false,<br></td></tr
><tr
id=sl_svn82_575

><td class="source">                //show: &quot;blind&quot;,<br></td></tr
><tr
id=sl_svn82_576

><td class="source">                hide: &quot;blind&quot;,<br></td></tr
><tr
id=sl_svn82_577

><td class="source">                buttons: [{<br></td></tr
><tr
id=sl_svn82_578

><td class="source">                    text: &quot;Reset&quot;,<br></td></tr
><tr
id=sl_svn82_579

><td class="source">                    click: function () {<br></td></tr
><tr
id=sl_svn82_580

><td class="source">                        //$(&#39;#&#39;+buttonId).removeClass(&quot;filter_selected&quot;); //LM remove border if filter selected<br></td></tr
><tr
id=sl_svn82_581

><td class="source">                        $(&#39;input:checkbox[name=&quot;&#39; + localLabel + &#39;&quot;]:checked&#39;).each(function (index3) {<br></td></tr
><tr
id=sl_svn82_582

><td class="source">                            $(this).attr(&#39;checked&#39;, false);<br></td></tr
><tr
id=sl_svn82_583

><td class="source">                            $(this).addClass(&quot;search_init&quot;);<br></td></tr
><tr
id=sl_svn82_584

><td class="source">                        });<br></td></tr
><tr
id=sl_svn82_585

><td class="source">                        oTable.fnFilter(&#39;&#39;, index, true, false);<br></td></tr
><tr
id=sl_svn82_586

><td class="source">                        fnOnFiltered();<br></td></tr
><tr
id=sl_svn82_587

><td class="source">                        return false;<br></td></tr
><tr
id=sl_svn82_588

><td class="source">                    }<br></td></tr
><tr
id=sl_svn82_589

><td class="source">                },<br></td></tr
><tr
id=sl_svn82_590

><td class="source">							{<br></td></tr
><tr
id=sl_svn82_591

><td class="source">							    text: &quot;Close&quot;,<br></td></tr
><tr
id=sl_svn82_592

><td class="source">							    click: function () { $(this).dialog(&quot;close&quot;); }<br></td></tr
><tr
id=sl_svn82_593

><td class="source">							}<br></td></tr
><tr
id=sl_svn82_594

><td class="source">						]<br></td></tr
><tr
id=sl_svn82_595

><td class="source">            });<br></td></tr
><tr
id=sl_svn82_596

><td class="source"><br></td></tr
><tr
id=sl_svn82_597

><td class="source"><br></td></tr
><tr
id=sl_svn82_598

><td class="source">            $(&#39;#&#39; + buttonId).click(function () {<br></td></tr
><tr
id=sl_svn82_599

><td class="source"><br></td></tr
><tr
id=sl_svn82_600

><td class="source">                $(&#39;#&#39; + checkToggleDiv).dialog(&#39;open&#39;);<br></td></tr
><tr
id=sl_svn82_601

><td class="source">                var target = $(this);<br></td></tr
><tr
id=sl_svn82_602

><td class="source">                $(&#39;#&#39; + checkToggleDiv).dialog(&quot;widget&quot;).position({ my: &#39;top&#39;,<br></td></tr
><tr
id=sl_svn82_603

><td class="source">                    at: &#39;bottom&#39;,<br></td></tr
><tr
id=sl_svn82_604

><td class="source">                    of: target<br></td></tr
><tr
id=sl_svn82_605

><td class="source">                });<br></td></tr
><tr
id=sl_svn82_606

><td class="source"><br></td></tr
><tr
id=sl_svn82_607

><td class="source">                return false;<br></td></tr
><tr
id=sl_svn82_608

><td class="source">            });<br></td></tr
><tr
id=sl_svn82_609

><td class="source"><br></td></tr
><tr
id=sl_svn82_610

><td class="source">            var fnOnFilteredCurrent = fnOnFiltered;<br></td></tr
><tr
id=sl_svn82_611

><td class="source"><br></td></tr
><tr
id=sl_svn82_612

><td class="source">            fnOnFiltered = function () {<br></td></tr
><tr
id=sl_svn82_613

><td class="source">                var target = $(&#39;#&#39; + buttonId);<br></td></tr
><tr
id=sl_svn82_614

><td class="source">                $(&#39;#&#39; + checkToggleDiv).dialog(&quot;widget&quot;).position({ my: &#39;top&#39;,<br></td></tr
><tr
id=sl_svn82_615

><td class="source">                    at: &#39;bottom&#39;,<br></td></tr
><tr
id=sl_svn82_616

><td class="source">                    of: target<br></td></tr
><tr
id=sl_svn82_617

><td class="source">                });<br></td></tr
><tr
id=sl_svn82_618

><td class="source">                fnOnFilteredCurrent();<br></td></tr
><tr
id=sl_svn82_619

><td class="source">            };<br></td></tr
><tr
id=sl_svn82_620

><td class="source">            //reset<br></td></tr
><tr
id=sl_svn82_621

><td class="source">            /*<br></td></tr
><tr
id=sl_svn82_622

><td class="source">            $(&#39;#&#39;+buttonId+&quot;Reset&quot;).button();<br></td></tr
><tr
id=sl_svn82_623

><td class="source">            $(&#39;#&#39;+buttonId+&quot;Reset&quot;).click(function(){<br></td></tr
><tr
id=sl_svn82_624

><td class="source">            $(&#39;#&#39;+buttonId).removeClass(&quot;filter_selected&quot;); //LM remove border if filter selected<br></td></tr
><tr
id=sl_svn82_625

><td class="source">            $(&#39;input:checkbox[name=&quot;&#39;+localLabel+&#39;&quot;]:checked&#39;).each(function(index3) {<br></td></tr
><tr
id=sl_svn82_626

><td class="source">            $(this).attr(&#39;checked&#39;, false);<br></td></tr
><tr
id=sl_svn82_627

><td class="source">            $(this).addClass(&quot;search_init&quot;);<br></td></tr
><tr
id=sl_svn82_628

><td class="source">            });<br></td></tr
><tr
id=sl_svn82_629

><td class="source">            oTable.fnFilter(&#39;&#39;, index, true, false);<br></td></tr
><tr
id=sl_svn82_630

><td class="source">            return false;<br></td></tr
><tr
id=sl_svn82_631

><td class="source">            }); <br></td></tr
><tr
id=sl_svn82_632

><td class="source">            */<br></td></tr
><tr
id=sl_svn82_633

><td class="source">        }<br></td></tr
><tr
id=sl_svn82_634

><td class="source"><br></td></tr
><tr
id=sl_svn82_635

><td class="source"><br></td></tr
><tr
id=sl_svn82_636

><td class="source"><br></td></tr
><tr
id=sl_svn82_637

><td class="source"><br></td></tr
><tr
id=sl_svn82_638

><td class="source">        function _fnRangeLabelPart(iPlace) {<br></td></tr
><tr
id=sl_svn82_639

><td class="source">            switch (iPlace) {<br></td></tr
><tr
id=sl_svn82_640

><td class="source">                case 0:<br></td></tr
><tr
id=sl_svn82_641

><td class="source">                    return sRangeFormat.substring(0, sRangeFormat.indexOf(&quot;{from}&quot;));<br></td></tr
><tr
id=sl_svn82_642

><td class="source">                case 1:<br></td></tr
><tr
id=sl_svn82_643

><td class="source">                    return sRangeFormat.substring(sRangeFormat.indexOf(&quot;{from}&quot;) + 6, sRangeFormat.indexOf(&quot;{to}&quot;));<br></td></tr
><tr
id=sl_svn82_644

><td class="source">                default:<br></td></tr
><tr
id=sl_svn82_645

><td class="source">                    return sRangeFormat.substring(sRangeFormat.indexOf(&quot;{to}&quot;) + 4);<br></td></tr
><tr
id=sl_svn82_646

><td class="source">            }<br></td></tr
><tr
id=sl_svn82_647

><td class="source">        }<br></td></tr
><tr
id=sl_svn82_648

><td class="source"><br></td></tr
><tr
id=sl_svn82_649

><td class="source"><br></td></tr
><tr
id=sl_svn82_650

><td class="source"><br></td></tr
><tr
id=sl_svn82_651

><td class="source"><br></td></tr
><tr
id=sl_svn82_652

><td class="source">        var oTable = this;<br></td></tr
><tr
id=sl_svn82_653

><td class="source"><br></td></tr
><tr
id=sl_svn82_654

><td class="source">        var defaults = {<br></td></tr
><tr
id=sl_svn82_655

><td class="source">            sPlaceHolder: &quot;foot&quot;,<br></td></tr
><tr
id=sl_svn82_656

><td class="source">            sRangeSeparator: &quot;~&quot;,<br></td></tr
><tr
id=sl_svn82_657

><td class="source">            iFilteringDelay: 500,<br></td></tr
><tr
id=sl_svn82_658

><td class="source">            aoColumns: null,<br></td></tr
><tr
id=sl_svn82_659

><td class="source">            sRangeFormat: &quot;From {from} to {to}&quot;,<br></td></tr
><tr
id=sl_svn82_660

><td class="source">            sDateFromToken: &quot;from&quot;,<br></td></tr
><tr
id=sl_svn82_661

><td class="source">            sDateToToken: &quot;to&quot;<br></td></tr
><tr
id=sl_svn82_662

><td class="source">        };<br></td></tr
><tr
id=sl_svn82_663

><td class="source"><br></td></tr
><tr
id=sl_svn82_664

><td class="source">        var properties = $.extend(defaults, options);<br></td></tr
><tr
id=sl_svn82_665

><td class="source"><br></td></tr
><tr
id=sl_svn82_666

><td class="source">        return this.each(function () {<br></td></tr
><tr
id=sl_svn82_667

><td class="source"><br></td></tr
><tr
id=sl_svn82_668

><td class="source">            if (!oTable.fnSettings().oFeatures.bFilter)<br></td></tr
><tr
id=sl_svn82_669

><td class="source">                return;<br></td></tr
><tr
id=sl_svn82_670

><td class="source">            asInitVals = new Array();<br></td></tr
><tr
id=sl_svn82_671

><td class="source"><br></td></tr
><tr
id=sl_svn82_672

><td class="source">            var aoFilterCells = oTable.fnSettings().aoFooter[0];<br></td></tr
><tr
id=sl_svn82_673

><td class="source"><br></td></tr
><tr
id=sl_svn82_674

><td class="source">            var oHost = oTable.fnSettings().nTFoot; //Before fix for ColVis<br></td></tr
><tr
id=sl_svn82_675

><td class="source">            var sFilterRow = &quot;tr&quot;; //Before fix for ColVis<br></td></tr
><tr
id=sl_svn82_676

><td class="source"><br></td></tr
><tr
id=sl_svn82_677

><td class="source">            if (properties.sPlaceHolder == &quot;head:after&quot;) {<br></td></tr
><tr
id=sl_svn82_678

><td class="source">                var tr = $(&quot;tr:first&quot;, oTable.fnSettings().nTHead).detach();<br></td></tr
><tr
id=sl_svn82_679

><td class="source">                //tr.appendTo($(oTable.fnSettings().nTHead));<br></td></tr
><tr
id=sl_svn82_680

><td class="source">                if (oTable.fnSettings().bSortCellsTop) {<br></td></tr
><tr
id=sl_svn82_681

><td class="source">                    tr.prependTo($(oTable.fnSettings().nTHead));<br></td></tr
><tr
id=sl_svn82_682

><td class="source">                    //tr.appendTo($(&quot;thead&quot;, oTable));<br></td></tr
><tr
id=sl_svn82_683

><td class="source">                    aoFilterCells = oTable.fnSettings().aoHeader[1];<br></td></tr
><tr
id=sl_svn82_684

><td class="source">                }<br></td></tr
><tr
id=sl_svn82_685

><td class="source">                else {<br></td></tr
><tr
id=sl_svn82_686

><td class="source">                    tr.appendTo($(oTable.fnSettings().nTHead));<br></td></tr
><tr
id=sl_svn82_687

><td class="source">                    //tr.prependTo($(&quot;thead&quot;, oTable));<br></td></tr
><tr
id=sl_svn82_688

><td class="source">                    aoFilterCells = oTable.fnSettings().aoHeader[0];<br></td></tr
><tr
id=sl_svn82_689

><td class="source">                }<br></td></tr
><tr
id=sl_svn82_690

><td class="source"><br></td></tr
><tr
id=sl_svn82_691

><td class="source">                sFilterRow = &quot;tr:last&quot;;<br></td></tr
><tr
id=sl_svn82_692

><td class="source">                oHost = oTable.fnSettings().nTHead;<br></td></tr
><tr
id=sl_svn82_693

><td class="source"><br></td></tr
><tr
id=sl_svn82_694

><td class="source">            } else if (properties.sPlaceHolder == &quot;head:before&quot;) {<br></td></tr
><tr
id=sl_svn82_695

><td class="source"><br></td></tr
><tr
id=sl_svn82_696

><td class="source">                if (oTable.fnSettings().bSortCellsTop) {<br></td></tr
><tr
id=sl_svn82_697

><td class="source">                    var tr = $(&quot;tr:first&quot;, oTable.fnSettings().nTHead).detach();<br></td></tr
><tr
id=sl_svn82_698

><td class="source">                    tr.appendTo($(oTable.fnSettings().nTHead));<br></td></tr
><tr
id=sl_svn82_699

><td class="source">                    aoFilterCells = oTable.fnSettings().aoHeader[1];<br></td></tr
><tr
id=sl_svn82_700

><td class="source">                } else {<br></td></tr
><tr
id=sl_svn82_701

><td class="source">                    aoFilterCells = oTable.fnSettings().aoHeader[0];<br></td></tr
><tr
id=sl_svn82_702

><td class="source">                }<br></td></tr
><tr
id=sl_svn82_703

><td class="source">                /*else {<br></td></tr
><tr
id=sl_svn82_704

><td class="source">                //tr.prependTo($(&quot;thead&quot;, oTable));<br></td></tr
><tr
id=sl_svn82_705

><td class="source">                sFilterRow = &quot;tr:first&quot;;<br></td></tr
><tr
id=sl_svn82_706

><td class="source">                }*/<br></td></tr
><tr
id=sl_svn82_707

><td class="source"><br></td></tr
><tr
id=sl_svn82_708

><td class="source">                sFilterRow = &quot;tr:first&quot;;<br></td></tr
><tr
id=sl_svn82_709

><td class="source"><br></td></tr
><tr
id=sl_svn82_710

><td class="source">                oHost = oTable.fnSettings().nTHead;<br></td></tr
><tr
id=sl_svn82_711

><td class="source"><br></td></tr
><tr
id=sl_svn82_712

><td class="source">                <br></td></tr
><tr
id=sl_svn82_713

><td class="source">            }<br></td></tr
><tr
id=sl_svn82_714

><td class="source"><br></td></tr
><tr
id=sl_svn82_715

><td class="source">            //$(sFilterRow + &quot; th&quot;, oHost).each(function (index) {//bug with ColVis<br></td></tr
><tr
id=sl_svn82_716

><td class="source">            $(aoFilterCells).each(function (index) {//fix for ColVis<br></td></tr
><tr
id=sl_svn82_717

><td class="source">                i = index;<br></td></tr
><tr
id=sl_svn82_718

><td class="source">                var aoColumn = { type: &quot;text&quot;,<br></td></tr
><tr
id=sl_svn82_719

><td class="source">                    bRegex: false,<br></td></tr
><tr
id=sl_svn82_720

><td class="source">                    bSmart: true,<br></td></tr
><tr
id=sl_svn82_721

><td class="source">                    iMaxLenght: -1,<br></td></tr
><tr
id=sl_svn82_722

><td class="source">                    iFilterLength: 0<br></td></tr
><tr
id=sl_svn82_723

><td class="source">                };<br></td></tr
><tr
id=sl_svn82_724

><td class="source">                if (properties.aoColumns != null) {<br></td></tr
><tr
id=sl_svn82_725

><td class="source">                    if (properties.aoColumns.length &lt; i || properties.aoColumns[i] == null)<br></td></tr
><tr
id=sl_svn82_726

><td class="source">                        return;<br></td></tr
><tr
id=sl_svn82_727

><td class="source">                    aoColumn = properties.aoColumns[i];<br></td></tr
><tr
id=sl_svn82_728

><td class="source">                }<br></td></tr
><tr
id=sl_svn82_729

><td class="source">                //label = $(this).text(); //Before fix for ColVis<br></td></tr
><tr
id=sl_svn82_730

><td class="source">                label = $($(this)[0].cell).text(); //Fix for ColVis<br></td></tr
><tr
id=sl_svn82_731

><td class="source">                if (aoColumn.sSelector == null) {<br></td></tr
><tr
id=sl_svn82_732

><td class="source">                    //th = $($(this)[0]);//Before fix for ColVis<br></td></tr
><tr
id=sl_svn82_733

><td class="source">                    th = $($(this)[0].cell); //Fix for ColVis<br></td></tr
><tr
id=sl_svn82_734

><td class="source">                }<br></td></tr
><tr
id=sl_svn82_735

><td class="source">                else {<br></td></tr
><tr
id=sl_svn82_736

><td class="source">                    th = $(aoColumn.sSelector);<br></td></tr
><tr
id=sl_svn82_737

><td class="source">                    if (th.length == 0)<br></td></tr
><tr
id=sl_svn82_738

><td class="source">                        th = $($(this)[0].cell);<br></td></tr
><tr
id=sl_svn82_739

><td class="source">                }<br></td></tr
><tr
id=sl_svn82_740

><td class="source"><br></td></tr
><tr
id=sl_svn82_741

><td class="source">                if (aoColumn != null) {<br></td></tr
><tr
id=sl_svn82_742

><td class="source">                    if (aoColumn.sRangeFormat != null)<br></td></tr
><tr
id=sl_svn82_743

><td class="source">                        sRangeFormat = aoColumn.sRangeFormat;<br></td></tr
><tr
id=sl_svn82_744

><td class="source">                    else<br></td></tr
><tr
id=sl_svn82_745

><td class="source">                        sRangeFormat = properties.sRangeFormat;<br></td></tr
><tr
id=sl_svn82_746

><td class="source">                    switch (aoColumn.type) {<br></td></tr
><tr
id=sl_svn82_747

><td class="source">                        case &quot;null&quot;:<br></td></tr
><tr
id=sl_svn82_748

><td class="source">                            break;<br></td></tr
><tr
id=sl_svn82_749

><td class="source">                        case &quot;number&quot;:<br></td></tr
><tr
id=sl_svn82_750

><td class="source">                            fnCreateInput(oTable, true, false, true, aoColumn.iFilterLength, aoColumn.iMaxLenght);<br></td></tr
><tr
id=sl_svn82_751

><td class="source">                            break;<br></td></tr
><tr
id=sl_svn82_752

><td class="source">                        case &quot;select&quot;:<br></td></tr
><tr
id=sl_svn82_753

><td class="source">                            if (aoColumn.bRegex != true)<br></td></tr
><tr
id=sl_svn82_754

><td class="source">                                aoColumn.bRegex = false;<br></td></tr
><tr
id=sl_svn82_755

><td class="source">                            fnCreateSelect(oTable, aoColumn.values, aoColumn.bRegex, aoColumn.selected, aoColumn.multiple);<br></td></tr
><tr
id=sl_svn82_756

><td class="source">                            break;<br></td></tr
><tr
id=sl_svn82_757

><td class="source">                        case &quot;number-range&quot;:<br></td></tr
><tr
id=sl_svn82_758

><td class="source">                            fnCreateRangeInput(oTable);<br></td></tr
><tr
id=sl_svn82_759

><td class="source">                            break;<br></td></tr
><tr
id=sl_svn82_760

><td class="source">                        case &quot;date-range&quot;:<br></td></tr
><tr
id=sl_svn82_761

><td class="source">                            fnCreateDateRangeInput(oTable);<br></td></tr
><tr
id=sl_svn82_762

><td class="source">                            break;<br></td></tr
><tr
id=sl_svn82_763

><td class="source">                        case &quot;checkbox&quot;:<br></td></tr
><tr
id=sl_svn82_764

><td class="source">                            fnCreateCheckbox(oTable, aoColumn.values);<br></td></tr
><tr
id=sl_svn82_765

><td class="source">                            break;<br></td></tr
><tr
id=sl_svn82_766

><td class="source">						case &quot;twitter-dropdown&quot;:<br></td></tr
><tr
id=sl_svn82_767

><td class="source">						case &quot;dropdown&quot;:<br></td></tr
><tr
id=sl_svn82_768

><td class="source">                            fnCreateDropdown(aoColumn.values);<br></td></tr
><tr
id=sl_svn82_769

><td class="source">                            break;<br></td></tr
><tr
id=sl_svn82_770

><td class="source">                        case &quot;text&quot;:<br></td></tr
><tr
id=sl_svn82_771

><td class="source">                        default:<br></td></tr
><tr
id=sl_svn82_772

><td class="source">                            bRegex = (aoColumn.bRegex == null ? false : aoColumn.bRegex);<br></td></tr
><tr
id=sl_svn82_773

><td class="source">                            bSmart = (aoColumn.bSmart == null ? false : aoColumn.bSmart);<br></td></tr
><tr
id=sl_svn82_774

><td class="source">                            fnCreateInput(oTable, bRegex, bSmart, false, aoColumn.iFilterLength, aoColumn.iMaxLenght);<br></td></tr
><tr
id=sl_svn82_775

><td class="source">                            break;<br></td></tr
><tr
id=sl_svn82_776

><td class="source"><br></td></tr
><tr
id=sl_svn82_777

><td class="source">                    }<br></td></tr
><tr
id=sl_svn82_778

><td class="source">                }<br></td></tr
><tr
id=sl_svn82_779

><td class="source">            });<br></td></tr
><tr
id=sl_svn82_780

><td class="source"><br></td></tr
><tr
id=sl_svn82_781

><td class="source">            for (j = 0; j &lt; aiCustomSearch_Indexes.length; j++) {<br></td></tr
><tr
id=sl_svn82_782

><td class="source">                //var index = aiCustomSearch_Indexes[j];<br></td></tr
><tr
id=sl_svn82_783

><td class="source">                var fnSearch_ = function () {<br></td></tr
><tr
id=sl_svn82_784

><td class="source">                    var id = oTable.attr(&quot;id&quot;);<br></td></tr
><tr
id=sl_svn82_785

><td class="source">                    return $(&quot;#&quot; + id + &quot;_range_from_&quot; + aiCustomSearch_Indexes[j]).val() + properties.sRangeSeparator + $(&quot;#&quot; + id + &quot;_range_to_&quot; + aiCustomSearch_Indexes[j]).val()<br></td></tr
><tr
id=sl_svn82_786

><td class="source">                }<br></td></tr
><tr
id=sl_svn82_787

><td class="source">                afnSearch_.push(fnSearch_);<br></td></tr
><tr
id=sl_svn82_788

><td class="source">            }<br></td></tr
><tr
id=sl_svn82_789

><td class="source"><br></td></tr
><tr
id=sl_svn82_790

><td class="source">            if (oTable.fnSettings().oFeatures.bServerSide) {<br></td></tr
><tr
id=sl_svn82_791

><td class="source"><br></td></tr
><tr
id=sl_svn82_792

><td class="source">                var fnServerDataOriginal = oTable.fnSettings().fnServerData;<br></td></tr
><tr
id=sl_svn82_793

><td class="source"><br></td></tr
><tr
id=sl_svn82_794

><td class="source">                oTable.fnSettings().fnServerData = function (sSource, aoData, fnCallback) {<br></td></tr
><tr
id=sl_svn82_795

><td class="source"><br></td></tr
><tr
id=sl_svn82_796

><td class="source">                    for (j = 0; j &lt; aiCustomSearch_Indexes.length; j++) {<br></td></tr
><tr
id=sl_svn82_797

><td class="source">                        var index = aiCustomSearch_Indexes[j];<br></td></tr
><tr
id=sl_svn82_798

><td class="source"><br></td></tr
><tr
id=sl_svn82_799

><td class="source">                        for (k = 0; k &lt; aoData.length; k++) {<br></td></tr
><tr
id=sl_svn82_800

><td class="source">                            if (aoData[k].name == &quot;sSearch_&quot; + index)<br></td></tr
><tr
id=sl_svn82_801

><td class="source">                                aoData[k].value = afnSearch_[j]();<br></td></tr
><tr
id=sl_svn82_802

><td class="source">                        }<br></td></tr
><tr
id=sl_svn82_803

><td class="source">                    }<br></td></tr
><tr
id=sl_svn82_804

><td class="source">                    aoData.push({ &quot;name&quot;: &quot;sRangeSeparator&quot;, &quot;value&quot;: properties.sRangeSeparator });<br></td></tr
><tr
id=sl_svn82_805

><td class="source"><br></td></tr
><tr
id=sl_svn82_806

><td class="source">                    if (fnServerDataOriginal != null) {<br></td></tr
><tr
id=sl_svn82_807

><td class="source">                        try {<br></td></tr
><tr
id=sl_svn82_808

><td class="source">                            fnServerDataOriginal(sSource, aoData, fnCallback, oTable.fnSettings()); //TODO: See Issue 18<br></td></tr
><tr
id=sl_svn82_809

><td class="source">                        } catch (ex) {<br></td></tr
><tr
id=sl_svn82_810

><td class="source">                            fnServerDataOriginal(sSource, aoData, fnCallback);<br></td></tr
><tr
id=sl_svn82_811

><td class="source">                        }<br></td></tr
><tr
id=sl_svn82_812

><td class="source">                    }<br></td></tr
><tr
id=sl_svn82_813

><td class="source">                    else {<br></td></tr
><tr
id=sl_svn82_814

><td class="source">                        $.getJSON(sSource, aoData, function (json) {<br></td></tr
><tr
id=sl_svn82_815

><td class="source">                            fnCallback(json)<br></td></tr
><tr
id=sl_svn82_816

><td class="source">                        });<br></td></tr
><tr
id=sl_svn82_817

><td class="source">                    }<br></td></tr
><tr
id=sl_svn82_818

><td class="source">                };<br></td></tr
><tr
id=sl_svn82_819

><td class="source"><br></td></tr
><tr
id=sl_svn82_820

><td class="source">            }<br></td></tr
><tr
id=sl_svn82_821

><td class="source"><br></td></tr
><tr
id=sl_svn82_822

><td class="source">        });<br></td></tr
><tr
id=sl_svn82_823

><td class="source"><br></td></tr
><tr
id=sl_svn82_824

><td class="source">    };<br></td></tr
><tr
id=sl_svn82_825

><td class="source"><br></td></tr
><tr
id=sl_svn82_826

><td class="source"><br></td></tr
><tr
id=sl_svn82_827

><td class="source"><br></td></tr
><tr
id=sl_svn82_828

><td class="source"><br></td></tr
><tr
id=sl_svn82_829

><td class="source">})(jQuery);<br></td></tr
></table></pre>
<pre><table width="100%"><tr class="cursor_stop cursor_hidden"><td></td></tr></table></pre>
</td>
</tr></table>

 
<script type="text/javascript">
 var lineNumUnderMouse = -1;
 
 function gutterOver(num) {
 gutterOut();
 var newTR = document.getElementById('gr_svn82_' + num);
 if (newTR) {
 newTR.className = 'undermouse';
 }
 lineNumUnderMouse = num;
 }
 function gutterOut() {
 if (lineNumUnderMouse != -1) {
 var oldTR = document.getElementById(
 'gr_svn82_' + lineNumUnderMouse);
 if (oldTR) {
 oldTR.className = '';
 }
 lineNumUnderMouse = -1;
 }
 }
 var numsGenState = {table_base_id: 'nums_table_'};
 var srcGenState = {table_base_id: 'src_table_'};
 var alignerRunning = false;
 var startOver = false;
 function setLineNumberHeights() {
 if (alignerRunning) {
 startOver = true;
 return;
 }
 numsGenState.chunk_id = 0;
 numsGenState.table = document.getElementById('nums_table_0');
 numsGenState.row_num = 0;
 if (!numsGenState.table) {
 return; // Silently exit if no file is present.
 }
 srcGenState.chunk_id = 0;
 srcGenState.table = document.getElementById('src_table_0');
 srcGenState.row_num = 0;
 alignerRunning = true;
 continueToSetLineNumberHeights();
 }
 function rowGenerator(genState) {
 if (genState.row_num < genState.table.rows.length) {
 var currentRow = genState.table.rows[genState.row_num];
 genState.row_num++;
 return currentRow;
 }
 var newTable = document.getElementById(
 genState.table_base_id + (genState.chunk_id + 1));
 if (newTable) {
 genState.chunk_id++;
 genState.row_num = 0;
 genState.table = newTable;
 return genState.table.rows[0];
 }
 return null;
 }
 var MAX_ROWS_PER_PASS = 1000;
 function continueToSetLineNumberHeights() {
 var rowsInThisPass = 0;
 var numRow = 1;
 var srcRow = 1;
 while (numRow && srcRow && rowsInThisPass < MAX_ROWS_PER_PASS) {
 numRow = rowGenerator(numsGenState);
 srcRow = rowGenerator(srcGenState);
 rowsInThisPass++;
 if (numRow && srcRow) {
 if (numRow.offsetHeight != srcRow.offsetHeight) {
 numRow.firstChild.style.height = srcRow.offsetHeight + 'px';
 }
 }
 }
 if (rowsInThisPass >= MAX_ROWS_PER_PASS) {
 setTimeout(continueToSetLineNumberHeights, 10);
 } else {
 alignerRunning = false;
 if (startOver) {
 startOver = false;
 setTimeout(setLineNumberHeights, 500);
 }
 }
 }
 function initLineNumberHeights() {
 // Do 2 complete passes, because there can be races
 // between this code and prettify.
 startOver = true;
 setTimeout(setLineNumberHeights, 250);
 window.onresize = setLineNumberHeights;
 }
 initLineNumberHeights();
</script>

 
 
 <div id="log">
 <div style="text-align:right">
 <a class="ifCollapse" href="#" onclick="_toggleMeta(this); return false">Show details</a>
 <a class="ifExpand" href="#" onclick="_toggleMeta(this); return false">Hide details</a>
 </div>
 <div class="ifExpand">
 
 
 <div class="pmeta_bubble_bg" style="border:1px solid white">
 <div class="round4"></div>
 <div class="round2"></div>
 <div class="round1"></div>
 <div class="box-inner">
 <div id="changelog">
 <p>Change log</p>
 <div>
 <a href="/p/jquery-datatables-column-filter/source/detail?spec=svn82&amp;r=82">r82</a>
 by jocapc
 on Yesterday (34 hours ago)
 &nbsp; <a href="/p/jquery-datatables-column-filter/source/diff?spec=svn82&r=82&amp;format=side&amp;path=/trunk/media/js/jquery.dataTables.columnFilter.js&amp;old_path=/trunk/media/js/jquery.dataTables.columnFilter.js&amp;old=81">Diff</a>
 </div>
 <pre>v 1.5.6. added bootstrap css classes</pre>
 </div>
 
 
 
 
 
 
 <script type="text/javascript">
 var detail_url = '/p/jquery-datatables-column-filter/source/detail?r=82&spec=svn82';
 var publish_url = '/p/jquery-datatables-column-filter/source/detail?r=82&spec=svn82#publish';
 // describe the paths of this revision in javascript.
 var changed_paths = [];
 var changed_urls = [];
 
 changed_paths.push('/trunk/media/js/jquery.dataTables.columnFilter.js');
 changed_urls.push('/p/jquery-datatables-column-filter/source/browse/trunk/media/js/jquery.dataTables.columnFilter.js?r\x3d82\x26spec\x3dsvn82');
 
 var selected_path = '/trunk/media/js/jquery.dataTables.columnFilter.js';
 
 
 function getCurrentPageIndex() {
 for (var i = 0; i < changed_paths.length; i++) {
 if (selected_path == changed_paths[i]) {
 return i;
 }
 }
 }
 function getNextPage() {
 var i = getCurrentPageIndex();
 if (i < changed_paths.length - 1) {
 return changed_urls[i + 1];
 }
 return null;
 }
 function getPreviousPage() {
 var i = getCurrentPageIndex();
 if (i > 0) {
 return changed_urls[i - 1];
 }
 return null;
 }
 function gotoNextPage() {
 var page = getNextPage();
 if (!page) {
 page = detail_url;
 }
 window.location = page;
 }
 function gotoPreviousPage() {
 var page = getPreviousPage();
 if (!page) {
 page = detail_url;
 }
 window.location = page;
 }
 function gotoDetailPage() {
 window.location = detail_url;
 }
 function gotoPublishPage() {
 window.location = publish_url;
 }
</script>

 
 <style type="text/css">
 #review_nav {
 border-top: 3px solid white;
 padding-top: 6px;
 margin-top: 1em;
 }
 #review_nav td {
 vertical-align: middle;
 }
 #review_nav select {
 margin: .5em 0;
 }
 </style>
 <div id="review_nav">
 <table><tr><td>Go to:&nbsp;</td><td>
 <select name="files_in_rev" onchange="window.location=this.value">
 
 <option value="/p/jquery-datatables-column-filter/source/browse/trunk/media/js/jquery.dataTables.columnFilter.js?r=82&amp;spec=svn82"
 selected="selected"
 >...query.dataTables.columnFilter.js</option>
 
 </select>
 </td></tr></table>
 
 
 



 
 </div>
 
 
 </div>
 <div class="round1"></div>
 <div class="round2"></div>
 <div class="round4"></div>
 </div>
 <div class="pmeta_bubble_bg" style="border:1px solid white">
 <div class="round4"></div>
 <div class="round2"></div>
 <div class="round1"></div>
 <div class="box-inner">
 <div id="older_bubble">
 <p>Older revisions</p>
 
 
 <div class="closed" style="margin-bottom:3px;" >
 <a class="ifClosed" onclick="return _toggleHidden(this)"><img src="https://ssl.gstatic.com/codesite/ph/images/plus.gif" ></a>
 <a class="ifOpened" onclick="return _toggleHidden(this)"><img src="https://ssl.gstatic.com/codesite/ph/images/minus.gif" ></a>
 <a href="/p/jquery-datatables-column-filter/source/detail?spec=svn82&r=81">r81</a>
 by jocapc
 on Feb 23, 2014
 &nbsp; <a href="/p/jquery-datatables-column-filter/source/diff?spec=svn82&r=81&amp;format=side&amp;path=/trunk/media/js/jquery.dataTables.columnFilter.js&amp;old_path=/trunk/media/js/jquery.dataTables.columnFilter.js&amp;old=80">Diff</a>
 <br>
 <pre class="ifOpened">v.1.5.5. Minor fix.</pre>
 </div>
 
 <div class="closed" style="margin-bottom:3px;" >
 <a class="ifClosed" onclick="return _toggleHidden(this)"><img src="https://ssl.gstatic.com/codesite/ph/images/plus.gif" ></a>
 <a class="ifOpened" onclick="return _toggleHidden(this)"><img src="https://ssl.gstatic.com/codesite/ph/images/minus.gif" ></a>
 <a href="/p/jquery-datatables-column-filter/source/detail?spec=svn82&r=80">r80</a>
 by jocapc
 on Feb 23, 2014
 &nbsp; <a href="/p/jquery-datatables-column-filter/source/diff?spec=svn82&r=80&amp;format=side&amp;path=/trunk/media/js/jquery.dataTables.columnFilter.js&amp;old_path=/trunk/media/js/jquery.dataTables.columnFilter.js&amp;old=79">Diff</a>
 <br>
 <pre class="ifOpened">v 1.5.5. Added Multiple option in
plugin (still unofficially) with
example.</pre>
 </div>
 
 <div class="closed" style="margin-bottom:3px;" >
 <a class="ifClosed" onclick="return _toggleHidden(this)"><img src="https://ssl.gstatic.com/codesite/ph/images/plus.gif" ></a>
 <a class="ifOpened" onclick="return _toggleHidden(this)"><img src="https://ssl.gstatic.com/codesite/ph/images/minus.gif" ></a>
 <a href="/p/jquery-datatables-column-filter/source/detail?spec=svn82&r=79">r79</a>
 by jocapc
 on Feb 23, 2014
 &nbsp; <a href="/p/jquery-datatables-column-filter/source/diff?spec=svn82&r=79&amp;format=side&amp;path=/trunk/media/js/jquery.dataTables.columnFilter.js&amp;old_path=/trunk/media/js/jquery.dataTables.columnFilter.js&amp;old=77">Diff</a>
 <br>
 <pre class="ifOpened">v1.5.4. added possibility to define a
function as an source of items in
select filter.</pre>
 </div>
 
 
 <a href="/p/jquery-datatables-column-filter/source/list?path=/trunk/media/js/jquery.dataTables.columnFilter.js&start=82">All revisions of this file</a>
 </div>
 </div>
 <div class="round1"></div>
 <div class="round2"></div>
 <div class="round4"></div>
 </div>
 
 <div class="pmeta_bubble_bg" style="border:1px solid white">
 <div class="round4"></div>
 <div class="round2"></div>
 <div class="round1"></div>
 <div class="box-inner">
 <div id="fileinfo_bubble">
 <p>File info</p>
 
 <div>Size: 34508 bytes,
 829 lines</div>
 
 <div><a href="//jquery-datatables-column-filter.googlecode.com/svn/trunk/media/js/jquery.dataTables.columnFilter.js">View raw file</a></div>
 </div>
 
 <div id="props">
 <p>File properties</p>
 <dl>
 
 <dt>svn:mime-type</dt>
 <dd>text/javascript</dd>
 
 </dl>
 </div>
 
 </div>
 <div class="round1"></div>
 <div class="round2"></div>
 <div class="round4"></div>
 </div>
 </div>
 </div>


</div>

</div>
</div>

<script src="https://ssl.gstatic.com/codesite/ph/11512667522589661435/js/prettify/prettify.js"></script>
<script type="text/javascript">prettyPrint();</script>


<script src="https://ssl.gstatic.com/codesite/ph/11512667522589661435/js/source_file_scripts.js"></script>

 <script type="text/javascript" src="https://ssl.gstatic.com/codesite/ph/11512667522589661435/js/kibbles.js"></script>
 <script type="text/javascript">
 var lastStop = null;
 var initialized = false;
 
 function updateCursor(next, prev) {
 if (prev && prev.element) {
 prev.element.className = 'cursor_stop cursor_hidden';
 }
 if (next && next.element) {
 next.element.className = 'cursor_stop cursor';
 lastStop = next.index;
 }
 }
 
 function pubRevealed(data) {
 updateCursorForCell(data.cellId, 'cursor_stop cursor_hidden');
 if (initialized) {
 reloadCursors();
 }
 }
 
 function draftRevealed(data) {
 updateCursorForCell(data.cellId, 'cursor_stop cursor_hidden');
 if (initialized) {
 reloadCursors();
 }
 }
 
 function draftDestroyed(data) {
 updateCursorForCell(data.cellId, 'nocursor');
 if (initialized) {
 reloadCursors();
 }
 }
 function reloadCursors() {
 kibbles.skipper.reset();
 loadCursors();
 if (lastStop != null) {
 kibbles.skipper.setCurrentStop(lastStop);
 }
 }
 // possibly the simplest way to insert any newly added comments
 // is to update the class of the corresponding cursor row,
 // then refresh the entire list of rows.
 function updateCursorForCell(cellId, className) {
 var cell = document.getElementById(cellId);
 // we have to go two rows back to find the cursor location
 var row = getPreviousElement(cell.parentNode);
 row.className = className;
 }
 // returns the previous element, ignores text nodes.
 function getPreviousElement(e) {
 var element = e.previousSibling;
 if (element.nodeType == 3) {
 element = element.previousSibling;
 }
 if (element && element.tagName) {
 return element;
 }
 }
 function loadCursors() {
 // register our elements with skipper
 var elements = CR_getElements('*', 'cursor_stop');
 var len = elements.length;
 for (var i = 0; i < len; i++) {
 var element = elements[i]; 
 element.className = 'cursor_stop cursor_hidden';
 kibbles.skipper.append(element);
 }
 }
 function toggleComments() {
 CR_toggleCommentDisplay();
 reloadCursors();
 }
 function keysOnLoadHandler() {
 // setup skipper
 kibbles.skipper.addStopListener(
 kibbles.skipper.LISTENER_TYPE.PRE, updateCursor);
 // Set the 'offset' option to return the middle of the client area
 // an option can be a static value, or a callback
 kibbles.skipper.setOption('padding_top', 50);
 // Set the 'offset' option to return the middle of the client area
 // an option can be a static value, or a callback
 kibbles.skipper.setOption('padding_bottom', 100);
 // Register our keys
 kibbles.skipper.addFwdKey("n");
 kibbles.skipper.addRevKey("p");
 kibbles.keys.addKeyPressListener(
 'u', function() { window.location = detail_url; });
 kibbles.keys.addKeyPressListener(
 'r', function() { window.location = detail_url + '#publish'; });
 
 kibbles.keys.addKeyPressListener('j', gotoNextPage);
 kibbles.keys.addKeyPressListener('k', gotoPreviousPage);
 
 
 }
 </script>
<script src="https://ssl.gstatic.com/codesite/ph/11512667522589661435/js/code_review_scripts.js"></script>
<script type="text/javascript">
 function showPublishInstructions() {
 var element = document.getElementById('review_instr');
 if (element) {
 element.className = 'opened';
 }
 }
 var codereviews;
 function revsOnLoadHandler() {
 // register our source container with the commenting code
 var paths = {'svn82': '/trunk/media/js/jquery.dataTables.columnFilter.js'}
 codereviews = CR_controller.setup(
 {"profileUrl": "/u/108303546530773324054/", "token": "daT9vRmcUgFdoZwQOykK5NHw6M4:1394866781053", "domainName": null, "assetHostPath": "https://ssl.gstatic.com/codesite/ph", "assetVersionPath": "https://ssl.gstatic.com/codesite/ph/11512667522589661435", "projectHomeUrl": "/p/jquery-datatables-column-filter", "relativeBaseUrl": "", "projectName": "jquery-datatables-column-filter", "loggedInUserEmail": "nguyen.hpn@gmail.com"}, '', 'svn82', paths,
 CR_BrowseIntegrationFactory);
 
 codereviews.registerActivityListener(CR_ActivityType.REVEAL_DRAFT_PLATE, showPublishInstructions);
 
 codereviews.registerActivityListener(CR_ActivityType.REVEAL_PUB_PLATE, pubRevealed);
 codereviews.registerActivityListener(CR_ActivityType.REVEAL_DRAFT_PLATE, draftRevealed);
 codereviews.registerActivityListener(CR_ActivityType.DISCARD_DRAFT_COMMENT, draftDestroyed);
 
 
 
 
 
 
 
 var initialized = true;
 reloadCursors();
 }
 window.onload = function() {keysOnLoadHandler(); revsOnLoadHandler();};

</script>
<script type="text/javascript" src="https://ssl.gstatic.com/codesite/ph/11512667522589661435/js/dit_scripts.js"></script>

 
 
 
 <script type="text/javascript" src="https://ssl.gstatic.com/codesite/ph/11512667522589661435/js/ph_core.js"></script>
 
 
 
 
</div> 

<div id="footer" dir="ltr">
 <div class="text">
 <a href="/projecthosting/terms.html">Terms</a> -
 <a href="http://www.google.com/privacy.html">Privacy</a> -
 <a href="/p/support/">Project Hosting Help</a>
 </div>
</div>
 <div class="hostedBy" style="margin-top: -20px;">
 <span style="vertical-align: top;">Powered by <a href="http://code.google.com/projecthosting/">Google Project Hosting</a></span>
 </div>

 
 


 
 </body>
</html>


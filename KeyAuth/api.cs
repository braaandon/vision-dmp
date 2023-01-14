using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading;

namespace KeyAuth
{
	// Token: 0x02000003 RID: 3
	public class api
	{
		// Token: 0x06000015 RID: 21 RVA: 0x00002340 File Offset: 0x00002340
		public api(string name, string ownerid, string secret, string version)
		{
			bool flag = string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(ownerid) || string.IsNullOrWhiteSpace(secret) || string.IsNullOrWhiteSpace(version);
			if (flag)
			{
				api.error("Application not setup correctly. Please watch video link found in Program.cs \n Make sure you've added your application name, secret, ownerID, and version in correctly, and that you have KeyAuthApp.init(); on load.");
				Environment.Exit(0);
			}
			this.name = name;
			this.ownerid = ownerid;
			this.secret = secret;
			this.version = version;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000023E0 File Offset: 0x000023E0
		public void init()
		{
			this.enckey = encryption.sha256(encryption.iv_key());
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("init"));
			nameValueCollection["ver"] = encryption.encrypt(this.version, this.secret, text);
			nameValueCollection["hash"] = api.checksum(Process.GetCurrentProcess().MainModule.FileName);
			nameValueCollection["enckey"] = encryption.encrypt(this.enckey, this.secret, text);
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			bool flag = text2 == "KeyAuth_Invalid";
			if (flag)
			{
				api.error("Application not found. Please check your application name, secret, ownerID, and version.");
				Environment.Exit(0);
			}
			text2 = encryption.decrypt(text2, this.secret, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			bool success = response_structure.success;
			if (success)
			{
				this.load_app_data(response_structure.appinfo);
				this.sessionid = response_structure.sessionid;
				this.initialized = true;
			}
			else
			{
				bool flag2 = response_structure.message == "invalidver";
				if (flag2)
				{
					this.app_data.downloadLink = response_structure.download;
				}
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002584 File Offset: 0x00002584
		public void register(string username, string pass, string key)
		{
			bool flag = !this.initialized;
			if (flag)
			{
				api.error("Please initialize first. Add KeyAuthApp.init(); on load.");
				Environment.Exit(0);
			}
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("register"));
			nameValueCollection["username"] = encryption.encrypt(username, this.enckey, text);
			nameValueCollection["pass"] = encryption.encrypt(pass, this.enckey, text);
			nameValueCollection["key"] = encryption.encrypt(key, this.enckey, text);
			nameValueCollection["hwid"] = encryption.encrypt(value, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			bool success = response_structure.success;
			if (success)
			{
				this.load_user_data(response_structure.info);
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002714 File Offset: 0x00002714
		public void login(string username, string pass)
		{
			bool flag = !this.initialized;
			if (flag)
			{
				api.error("Please initialize first. Add KeyAuthApp.init(); on load.");
				Environment.Exit(0);
			}
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("login"));
			nameValueCollection["username"] = encryption.encrypt(username, this.enckey, text);
			nameValueCollection["pass"] = encryption.encrypt(pass, this.enckey, text);
			nameValueCollection["hwid"] = encryption.encrypt(value, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			bool success = response_structure.success;
			if (success)
			{
				this.load_user_data(response_structure.info);
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002888 File Offset: 0x00002888
		public void web_login()
		{
			bool flag = !this.initialized;
			if (flag)
			{
				api.error("Please initialize first. Add KeyAuthApp.init(); on load.");
				Environment.Exit(0);
			}
			string value = WindowsIdentity.GetCurrent().User.Value;
			HttpListener httpListener = new HttpListener();
			string text = "handshake";
			text = "http://localhost:1337/" + text + "/";
			httpListener.Prefixes.Add(text);
			httpListener.Start();
			HttpListenerContext context = httpListener.GetContext();
			HttpListenerRequest request = context.Request;
			HttpListenerResponse httpListenerResponse = context.Response;
			httpListenerResponse.AddHeader("Access-Control-Allow-Methods", "GET, POST");
			httpListenerResponse.AddHeader("Access-Control-Allow-Origin", "*");
			httpListenerResponse.AddHeader("Via", "Via");
			httpListenerResponse.AddHeader("Location", "Location");
			httpListenerResponse.AddHeader("Retry-After", "Retry");
			httpListenerResponse.Headers.Add("Server", "\r\n\r\n");
			httpListener.AuthenticationSchemes = 2;
			httpListener.UnsafeConnectionNtlmAuthentication = true;
			httpListener.IgnoreWriteExceptions = true;
			string rawUrl = request.RawUrl;
			string text2 = rawUrl.Replace("/handshake?user=", "");
			text2 = text2.Replace("&token=", " ");
			string text3 = text2;
			string value2 = text3.Split(Array.Empty<char>())[0];
			string value3 = text3.Split(new char[]
			{
				' '
			})[1];
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = "login";
			nameValueCollection["username"] = value2;
			nameValueCollection["token"] = value3;
			nameValueCollection["hwid"] = value;
			nameValueCollection["sessionid"] = this.sessionid;
			nameValueCollection["name"] = this.name;
			nameValueCollection["ownerid"] = this.ownerid;
			NameValueCollection post_data = nameValueCollection;
			string json = api.req_unenc(post_data);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(json);
			this.load_response_struct(response_structure);
			bool flag2 = true;
			bool success = response_structure.success;
			if (success)
			{
				this.load_user_data(response_structure.info);
				httpListenerResponse.StatusCode = 420;
				httpListenerResponse.StatusDescription = "SHEESH";
			}
			else
			{
				Console.WriteLine(response_structure.message);
				httpListenerResponse.StatusCode = 200;
				httpListenerResponse.StatusDescription = response_structure.message;
				flag2 = false;
			}
			byte[] bytes = Encoding.UTF8.GetBytes("Whats up?");
			httpListenerResponse.ContentLength64 = (long)bytes.Length;
			Stream outputStream = httpListenerResponse.OutputStream;
			outputStream.Write(bytes, 0, bytes.Length);
			Thread.Sleep(1250);
			httpListener.Stop();
			bool flag3 = !flag2;
			if (flag3)
			{
				Environment.Exit(0);
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002B54 File Offset: 0x00002B54
		public void button(string button)
		{
			bool flag = !this.initialized;
			if (flag)
			{
				api.error("Please initialize first");
				Environment.Exit(0);
			}
			HttpListener httpListener = new HttpListener();
			string uriPrefix = "http://localhost:1337/" + button + "/";
			httpListener.Prefixes.Add(uriPrefix);
			httpListener.Start();
			HttpListenerContext context = httpListener.GetContext();
			HttpListenerRequest request = context.Request;
			HttpListenerResponse httpListenerResponse = context.Response;
			httpListenerResponse.AddHeader("Access-Control-Allow-Methods", "GET, POST");
			httpListenerResponse.AddHeader("Access-Control-Allow-Origin", "*");
			httpListenerResponse.AddHeader("Via", "Via");
			httpListenerResponse.AddHeader("Location", "Location");
			httpListenerResponse.AddHeader("Retry-After", "Rety");
			httpListenerResponse.Headers.Add("Server", "\r\n\r\n");
			httpListenerResponse.StatusCode = 420;
			httpListenerResponse.StatusDescription = "SHEESH";
			httpListener.AuthenticationSchemes = 2;
			httpListener.UnsafeConnectionNtlmAuthentication = true;
			httpListener.IgnoreWriteExceptions = true;
			httpListener.Stop();
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002C74 File Offset: 0x00002C74
		public void upgrade(string username, string key)
		{
			bool flag = !this.initialized;
			if (flag)
			{
				api.error("Please initialize first. Add KeyAuthApp.init(); on load.");
				Environment.Exit(0);
			}
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("upgrade"));
			nameValueCollection["username"] = encryption.encrypt(username, this.enckey, text);
			nameValueCollection["key"] = encryption.encrypt(key, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			response_structure.success = false;
			this.load_response_struct(response_structure);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002DC0 File Offset: 0x00002DC0
		public void license(string key)
		{
			bool flag = !this.initialized;
			if (flag)
			{
				api.error("Please initialize first. Add KeyAuthApp.init(); on load.");
				Environment.Exit(0);
			}
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("license"));
			nameValueCollection["key"] = encryption.encrypt(key, this.enckey, text);
			nameValueCollection["hwid"] = encryption.encrypt(value, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			bool success = response_structure.success;
			if (success)
			{
				this.load_user_data(response_structure.info);
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002F1C File Offset: 0x00002F1C
		public void check()
		{
			bool flag = !this.initialized;
			if (flag)
			{
				api.error("Please initialize first. Add KeyAuthApp.init(); on load.");
				Environment.Exit(0);
			}
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("check"));
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure data = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(data);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00003018 File Offset: 0x00003018
		public void setvar(string var, string data)
		{
			bool flag = !this.initialized;
			if (flag)
			{
				api.error("Please initialize first. Add KeyAuthApp.init(); on load.");
				Environment.Exit(0);
			}
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("setvar"));
			nameValueCollection["var"] = encryption.encrypt(var, this.enckey, text);
			nameValueCollection["data"] = encryption.encrypt(data, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure data2 = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(data2);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00003148 File Offset: 0x00003148
		public string getvar(string var)
		{
			bool flag = !this.initialized;
			if (flag)
			{
				api.error("Please initialize first. Add KeyAuthApp.init(); on load.");
				Environment.Exit(0);
			}
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("getvar"));
			nameValueCollection["var"] = encryption.encrypt(var, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			bool success = response_structure.success;
			string result;
			if (success)
			{
				result = response_structure.response;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x0000327C File Offset: 0x0000327C
		public void ban(string reason = null)
		{
			bool flag = !this.initialized;
			if (flag)
			{
				api.error("Please initialize first. Add KeyAuthApp.init(); on load.");
				Environment.Exit(0);
			}
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("ban"));
			nameValueCollection["reason"] = reason;
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure data = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(data);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00003388 File Offset: 0x00003388
		public string var(string varid)
		{
			bool flag = !this.initialized;
			if (flag)
			{
				api.error("Please initialize first. Add KeyAuthApp.init(); on load.");
				Environment.Exit(0);
			}
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("var"));
			nameValueCollection["varid"] = encryption.encrypt(varid, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			bool success = response_structure.success;
			string result;
			if (success)
			{
				result = response_structure.message;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000034D0 File Offset: 0x000034D0
		public List<api.users> fetchOnline()
		{
			bool flag = !this.initialized;
			if (flag)
			{
				api.error("Please initialize first. Add KeyAuthApp.init(); on load.");
				Environment.Exit(0);
			}
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("fetchOnline"));
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			bool success = response_structure.success;
			List<api.users> result;
			if (success)
			{
				result = response_structure.users;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000035EC File Offset: 0x000035EC
		public List<api.msg> chatget(string channelname)
		{
			bool flag = !this.initialized;
			if (flag)
			{
				api.error("Please initialize first. Add KeyAuthApp.init(); on load.");
				Environment.Exit(0);
			}
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("chatget"));
			nameValueCollection["channel"] = encryption.encrypt(channelname, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			bool success = response_structure.success;
			List<api.msg> result;
			if (success)
			{
				result = response_structure.messages;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00003720 File Offset: 0x00003720
		public bool chatsend(string msg, string channelname)
		{
			bool flag = !this.initialized;
			if (flag)
			{
				api.error("Please initialize first. Add KeyAuthApp.init(); on load.");
				Environment.Exit(0);
			}
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("chatsend"));
			nameValueCollection["message"] = encryption.encrypt(msg, this.enckey, text);
			nameValueCollection["channel"] = encryption.encrypt(channelname, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			return response_structure.success;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00003868 File Offset: 0x00003868
		public bool checkblack()
		{
			bool flag = !this.initialized;
			if (flag)
			{
				api.error("Please initialize first. Add KeyAuthApp.init(); on load.");
				Environment.Exit(0);
			}
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("checkblacklist"));
			nameValueCollection["hwid"] = encryption.encrypt(value, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			return response_structure.success;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000039A8 File Offset: 0x000039A8
		public string webhook(string webid, string param, string body = "", string conttype = "")
		{
			bool flag = !this.initialized;
			string result;
			if (flag)
			{
				api.error("Please initialize first. Add KeyAuthApp.init(); on load.");
				Environment.Exit(0);
				result = null;
			}
			else
			{
				string text = encryption.sha256(encryption.iv_key());
				NameValueCollection nameValueCollection = new NameValueCollection();
				nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("webhook"));
				nameValueCollection["webid"] = encryption.encrypt(webid, this.enckey, text);
				nameValueCollection["params"] = encryption.encrypt(param, this.enckey, text);
				nameValueCollection["body"] = encryption.encrypt(body, this.enckey, text);
				nameValueCollection["conttype"] = encryption.encrypt(conttype, this.enckey, text);
				nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
				nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
				nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
				nameValueCollection["init_iv"] = text;
				NameValueCollection post_data = nameValueCollection;
				string text2 = api.req(post_data);
				text2 = encryption.decrypt(text2, this.enckey, text);
				api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
				this.load_response_struct(response_structure);
				bool success = response_structure.success;
				if (success)
				{
					result = response_structure.response;
				}
				else
				{
					result = null;
				}
			}
			return result;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00003B30 File Offset: 0x00003B30
		public byte[] download(string fileid)
		{
			bool flag = !this.initialized;
			if (flag)
			{
				api.error("Please initialize first. Add KeyAuthApp.init(); on load. File is empty since no request could be made.");
				Environment.Exit(0);
			}
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("file"));
			nameValueCollection["fileid"] = encryption.encrypt(fileid, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			bool success = response_structure.success;
			byte[] result;
			if (success)
			{
				result = encryption.str_to_byte_arr(response_structure.contents);
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00003C68 File Offset: 0x00003C68
		public void log(string message)
		{
			bool flag = !this.initialized;
			if (flag)
			{
				api.error("Please initialize first. Add KeyAuthApp.init(); on load.");
				Environment.Exit(0);
			}
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("log"));
			nameValueCollection["pcuser"] = encryption.encrypt(Environment.UserName, this.enckey, text);
			nameValueCollection["message"] = encryption.encrypt(message, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			api.req(post_data);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00003D78 File Offset: 0x00003D78
		public static string checksum(string filename)
		{
			string result;
			using (MD5 md = MD5.Create())
			{
				using (FileStream fileStream = File.OpenRead(filename))
				{
					byte[] value = md.ComputeHash(fileStream);
					result = BitConverter.ToString(value).Replace("-", "").ToLowerInvariant();
				}
			}
			return result;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00003DF8 File Offset: 0x00003DF8
		public static void error(string message)
		{
			Process.Start(new ProcessStartInfo("cmd.exe", "/c start cmd /C \"color b && title Error && echo " + message + " && timeout /t 5\"")
			{
				CreateNoWindow = true,
				RedirectStandardOutput = true,
				RedirectStandardError = true,
				UseShellExecute = false
			});
			Environment.Exit(0);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00003E50 File Offset: 0x00003E50
		private static string req(NameValueCollection post_data)
		{
			api.RemoveUnwantedCert();
			string result;
			try
			{
				using (WebClient webClient = new WebClient())
				{
					byte[] bytes = webClient.UploadValues("https://keyauth.win/api/1.0/", post_data);
					result = Encoding.Default.GetString(bytes);
				}
			}
			catch (WebException ex)
			{
				HttpWebResponse httpWebResponse = (HttpWebResponse)ex.Response;
				HttpStatusCode statusCode = httpWebResponse.StatusCode;
				HttpStatusCode httpStatusCode = statusCode;
				if (httpStatusCode != 429)
				{
					api.error("Connection failure. Please try again, or contact us for help.");
					Environment.Exit(0);
					result = "";
				}
				else
				{
					api.error("You're connecting too fast to loader, slow down.");
					Environment.Exit(0);
					result = "";
				}
			}
			return result;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00003F0C File Offset: 0x00003F0C
		private static string req_unenc(NameValueCollection post_data)
		{
			api.RemoveUnwantedCert();
			string result;
			try
			{
				using (WebClient webClient = new WebClient())
				{
					byte[] bytes = webClient.UploadValues("https://keyauth.win/api/1.1/", post_data);
					result = Encoding.Default.GetString(bytes);
				}
			}
			catch (WebException ex)
			{
				HttpWebResponse httpWebResponse = (HttpWebResponse)ex.Response;
				HttpStatusCode statusCode = httpWebResponse.StatusCode;
				HttpStatusCode httpStatusCode = statusCode;
				if (httpStatusCode != 429)
				{
					api.error("Connection failure. Please try again, or contact us for help.");
					Environment.Exit(0);
					result = "";
				}
				else
				{
					Thread.Sleep(1000);
					result = api.req(post_data);
				}
			}
			return result;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00003FC0 File Offset: 0x00003FC0
		private static void RemoveUnwantedCert()
		{
			string storeName = "Root";
			StoreLocation storeLocation = StoreLocation.LocalMachine;
			X509Store x509Store = new X509Store(storeName, storeLocation);
			x509Store.Open(OpenFlags.ReadOnly);
			X509Certificate2Collection certificates = x509Store.Certificates;
			foreach (X509Certificate2 x509Certificate in certificates)
			{
				bool flag = x509Certificate.SubjectName.Name == "CN=asdhashdgashd";
				if (flag)
				{
					try
					{
						x509Store.Open(OpenFlags.ReadWrite);
						x509Store.Remove(x509Certificate);
						x509Store.Close();
					}
					catch (Exception)
					{
					}
					break;
				}
			}
			x509Store.Close();
			string storeName2 = "MY";
			StoreLocation storeLocation2 = StoreLocation.LocalMachine;
			X509Store x509Store2 = new X509Store(storeName2, storeLocation2);
			x509Store.Open(OpenFlags.ReadOnly);
			X509Certificate2Collection certificates2 = x509Store.Certificates;
			foreach (X509Certificate2 x509Certificate2 in certificates2)
			{
				bool flag2 = x509Certificate2.SubjectName.Name == "CN=asdhashdgashd";
				if (flag2)
				{
					try
					{
						x509Store2.Open(OpenFlags.ReadWrite);
						x509Store2.Remove(x509Certificate2);
						x509Store2.Close();
					}
					catch (Exception)
					{
					}
					break;
				}
			}
			x509Store2.Close();
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00004100 File Offset: 0x00004100
		private void load_app_data(api.app_data_structure data)
		{
			this.app_data.numUsers = data.numUsers;
			this.app_data.numOnlineUsers = data.numOnlineUsers;
			this.app_data.numKeys = data.numKeys;
			this.app_data.version = data.version;
			this.app_data.customerPanelLink = data.customerPanelLink;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00004168 File Offset: 0x00004168
		private void load_user_data(api.user_data_structure data)
		{
			this.user_data.username = data.username;
			this.user_data.ip = data.ip;
			this.user_data.hwid = data.hwid;
			this.user_data.createdate = data.createdate;
			this.user_data.lastlogin = data.lastlogin;
			this.user_data.subscriptions = data.subscriptions;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000041E4 File Offset: 0x000041E4
		public string expirydaysleft()
		{
			bool flag = !this.initialized;
			if (flag)
			{
				api.error("Please initialize first. Add KeyAuthApp.init(); on load.");
				Environment.Exit(0);
			}
			DateTime d = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local);
			d = d.AddSeconds((double)long.Parse(this.user_data.subscriptions[0].expiry)).ToLocalTime();
			TimeSpan timeSpan = d - DateTime.Now;
			return Convert.ToString(timeSpan.Days.ToString() + " Days " + timeSpan.Hours.ToString() + " Hours Left");
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00004298 File Offset: 0x00004298
		private void load_response_struct(api.response_structure data)
		{
			this.response.success = data.success;
			this.response.message = data.message;
		}

		// Token: 0x04000006 RID: 6
		public string name;

		// Token: 0x04000007 RID: 7
		public string ownerid;

		// Token: 0x04000008 RID: 8
		public string secret;

		// Token: 0x04000009 RID: 9
		public string version;

		// Token: 0x0400000A RID: 10
		private string sessionid;

		// Token: 0x0400000B RID: 11
		private string enckey;

		// Token: 0x0400000C RID: 12
		private bool initialized;

		// Token: 0x0400000D RID: 13
		public api.app_data_class app_data = new api.app_data_class();

		// Token: 0x0400000E RID: 14
		public api.user_data_class user_data = new api.user_data_class();

		// Token: 0x0400000F RID: 15
		public api.response_class response = new api.response_class();

		// Token: 0x04000010 RID: 16
		private json_wrapper response_decoder = new json_wrapper(new api.response_structure());

		// Token: 0x02000023 RID: 35
		[DataContract]
		private class response_structure
		{
			// Token: 0x17000041 RID: 65
			// (get) Token: 0x060001C2 RID: 450 RVA: 0x0001DFC8 File Offset: 0x0001DFC8
			// (set) Token: 0x060001C3 RID: 451 RVA: 0x0001DFD0 File Offset: 0x0001DFD0
			[DataMember]
			public bool success { get; set; }

			// Token: 0x17000042 RID: 66
			// (get) Token: 0x060001C4 RID: 452 RVA: 0x0001DFD9 File Offset: 0x0001DFD9
			// (set) Token: 0x060001C5 RID: 453 RVA: 0x0001DFE1 File Offset: 0x0001DFE1
			[DataMember]
			public string sessionid { get; set; }

			// Token: 0x17000043 RID: 67
			// (get) Token: 0x060001C6 RID: 454 RVA: 0x0001DFEA File Offset: 0x0001DFEA
			// (set) Token: 0x060001C7 RID: 455 RVA: 0x0001DFF2 File Offset: 0x0001DFF2
			[DataMember]
			public string contents { get; set; }

			// Token: 0x17000044 RID: 68
			// (get) Token: 0x060001C8 RID: 456 RVA: 0x0001DFFB File Offset: 0x0001DFFB
			// (set) Token: 0x060001C9 RID: 457 RVA: 0x0001E003 File Offset: 0x0001E003
			[DataMember]
			public string response { get; set; }

			// Token: 0x17000045 RID: 69
			// (get) Token: 0x060001CA RID: 458 RVA: 0x0001E00C File Offset: 0x0001E00C
			// (set) Token: 0x060001CB RID: 459 RVA: 0x0001E014 File Offset: 0x0001E014
			[DataMember]
			public string message { get; set; }

			// Token: 0x17000046 RID: 70
			// (get) Token: 0x060001CC RID: 460 RVA: 0x0001E01D File Offset: 0x0001E01D
			// (set) Token: 0x060001CD RID: 461 RVA: 0x0001E025 File Offset: 0x0001E025
			[DataMember]
			public string download { get; set; }

			// Token: 0x17000047 RID: 71
			// (get) Token: 0x060001CE RID: 462 RVA: 0x0001E02E File Offset: 0x0001E02E
			// (set) Token: 0x060001CF RID: 463 RVA: 0x0001E036 File Offset: 0x0001E036
			[DataMember(IsRequired = false, EmitDefaultValue = false)]
			public api.user_data_structure info { get; set; }

			// Token: 0x17000048 RID: 72
			// (get) Token: 0x060001D0 RID: 464 RVA: 0x0001E03F File Offset: 0x0001E03F
			// (set) Token: 0x060001D1 RID: 465 RVA: 0x0001E047 File Offset: 0x0001E047
			[DataMember(IsRequired = false, EmitDefaultValue = false)]
			public api.app_data_structure appinfo { get; set; }

			// Token: 0x17000049 RID: 73
			// (get) Token: 0x060001D2 RID: 466 RVA: 0x0001E050 File Offset: 0x0001E050
			// (set) Token: 0x060001D3 RID: 467 RVA: 0x0001E058 File Offset: 0x0001E058
			[DataMember]
			public List<api.msg> messages { get; set; }

			// Token: 0x1700004A RID: 74
			// (get) Token: 0x060001D4 RID: 468 RVA: 0x0001E061 File Offset: 0x0001E061
			// (set) Token: 0x060001D5 RID: 469 RVA: 0x0001E069 File Offset: 0x0001E069
			[DataMember]
			public List<api.users> users { get; set; }
		}

		// Token: 0x02000024 RID: 36
		public class msg
		{
			// Token: 0x1700004B RID: 75
			// (get) Token: 0x060001D7 RID: 471 RVA: 0x0001E07B File Offset: 0x0001E07B
			// (set) Token: 0x060001D8 RID: 472 RVA: 0x0001E083 File Offset: 0x0001E083
			public string message { get; set; }

			// Token: 0x1700004C RID: 76
			// (get) Token: 0x060001D9 RID: 473 RVA: 0x0001E08C File Offset: 0x0001E08C
			// (set) Token: 0x060001DA RID: 474 RVA: 0x0001E094 File Offset: 0x0001E094
			public string author { get; set; }

			// Token: 0x1700004D RID: 77
			// (get) Token: 0x060001DB RID: 475 RVA: 0x0001E09D File Offset: 0x0001E09D
			// (set) Token: 0x060001DC RID: 476 RVA: 0x0001E0A5 File Offset: 0x0001E0A5
			public string timestamp { get; set; }
		}

		// Token: 0x02000025 RID: 37
		public class users
		{
			// Token: 0x1700004E RID: 78
			// (get) Token: 0x060001DE RID: 478 RVA: 0x0001E0B7 File Offset: 0x0001E0B7
			// (set) Token: 0x060001DF RID: 479 RVA: 0x0001E0BF File Offset: 0x0001E0BF
			public string credential { get; set; }
		}

		// Token: 0x02000026 RID: 38
		[DataContract]
		private class user_data_structure
		{
			// Token: 0x1700004F RID: 79
			// (get) Token: 0x060001E1 RID: 481 RVA: 0x0001E0D1 File Offset: 0x0001E0D1
			// (set) Token: 0x060001E2 RID: 482 RVA: 0x0001E0D9 File Offset: 0x0001E0D9
			[DataMember]
			public string username { get; set; }

			// Token: 0x17000050 RID: 80
			// (get) Token: 0x060001E3 RID: 483 RVA: 0x0001E0E2 File Offset: 0x0001E0E2
			// (set) Token: 0x060001E4 RID: 484 RVA: 0x0001E0EA File Offset: 0x0001E0EA
			[DataMember]
			public string ip { get; set; }

			// Token: 0x17000051 RID: 81
			// (get) Token: 0x060001E5 RID: 485 RVA: 0x0001E0F3 File Offset: 0x0001E0F3
			// (set) Token: 0x060001E6 RID: 486 RVA: 0x0001E0FB File Offset: 0x0001E0FB
			[DataMember]
			public string hwid { get; set; }

			// Token: 0x17000052 RID: 82
			// (get) Token: 0x060001E7 RID: 487 RVA: 0x0001E104 File Offset: 0x0001E104
			// (set) Token: 0x060001E8 RID: 488 RVA: 0x0001E10C File Offset: 0x0001E10C
			[DataMember]
			public string createdate { get; set; }

			// Token: 0x17000053 RID: 83
			// (get) Token: 0x060001E9 RID: 489 RVA: 0x0001E115 File Offset: 0x0001E115
			// (set) Token: 0x060001EA RID: 490 RVA: 0x0001E11D File Offset: 0x0001E11D
			[DataMember]
			public string lastlogin { get; set; }

			// Token: 0x17000054 RID: 84
			// (get) Token: 0x060001EB RID: 491 RVA: 0x0001E126 File Offset: 0x0001E126
			// (set) Token: 0x060001EC RID: 492 RVA: 0x0001E12E File Offset: 0x0001E12E
			[DataMember]
			public List<api.Data> subscriptions { get; set; }
		}

		// Token: 0x02000027 RID: 39
		[DataContract]
		private class app_data_structure
		{
			// Token: 0x17000055 RID: 85
			// (get) Token: 0x060001EE RID: 494 RVA: 0x0001E140 File Offset: 0x0001E140
			// (set) Token: 0x060001EF RID: 495 RVA: 0x0001E148 File Offset: 0x0001E148
			[DataMember]
			public string numUsers { get; set; }

			// Token: 0x17000056 RID: 86
			// (get) Token: 0x060001F0 RID: 496 RVA: 0x0001E151 File Offset: 0x0001E151
			// (set) Token: 0x060001F1 RID: 497 RVA: 0x0001E159 File Offset: 0x0001E159
			[DataMember]
			public string numOnlineUsers { get; set; }

			// Token: 0x17000057 RID: 87
			// (get) Token: 0x060001F2 RID: 498 RVA: 0x0001E162 File Offset: 0x0001E162
			// (set) Token: 0x060001F3 RID: 499 RVA: 0x0001E16A File Offset: 0x0001E16A
			[DataMember]
			public string numKeys { get; set; }

			// Token: 0x17000058 RID: 88
			// (get) Token: 0x060001F4 RID: 500 RVA: 0x0001E173 File Offset: 0x0001E173
			// (set) Token: 0x060001F5 RID: 501 RVA: 0x0001E17B File Offset: 0x0001E17B
			[DataMember]
			public string version { get; set; }

			// Token: 0x17000059 RID: 89
			// (get) Token: 0x060001F6 RID: 502 RVA: 0x0001E184 File Offset: 0x0001E184
			// (set) Token: 0x060001F7 RID: 503 RVA: 0x0001E18C File Offset: 0x0001E18C
			[DataMember]
			public string customerPanelLink { get; set; }

			// Token: 0x1700005A RID: 90
			// (get) Token: 0x060001F8 RID: 504 RVA: 0x0001E195 File Offset: 0x0001E195
			// (set) Token: 0x060001F9 RID: 505 RVA: 0x0001E19D File Offset: 0x0001E19D
			[DataMember]
			public string downloadLink { get; set; }
		}

		// Token: 0x02000028 RID: 40
		public class app_data_class
		{
			// Token: 0x1700005B RID: 91
			// (get) Token: 0x060001FB RID: 507 RVA: 0x0001E1AF File Offset: 0x0001E1AF
			// (set) Token: 0x060001FC RID: 508 RVA: 0x0001E1B7 File Offset: 0x0001E1B7
			public string numUsers { get; set; }

			// Token: 0x1700005C RID: 92
			// (get) Token: 0x060001FD RID: 509 RVA: 0x0001E1C0 File Offset: 0x0001E1C0
			// (set) Token: 0x060001FE RID: 510 RVA: 0x0001E1C8 File Offset: 0x0001E1C8
			public string numOnlineUsers { get; set; }

			// Token: 0x1700005D RID: 93
			// (get) Token: 0x060001FF RID: 511 RVA: 0x0001E1D1 File Offset: 0x0001E1D1
			// (set) Token: 0x06000200 RID: 512 RVA: 0x0001E1D9 File Offset: 0x0001E1D9
			public string numKeys { get; set; }

			// Token: 0x1700005E RID: 94
			// (get) Token: 0x06000201 RID: 513 RVA: 0x0001E1E2 File Offset: 0x0001E1E2
			// (set) Token: 0x06000202 RID: 514 RVA: 0x0001E1EA File Offset: 0x0001E1EA
			public string version { get; set; }

			// Token: 0x1700005F RID: 95
			// (get) Token: 0x06000203 RID: 515 RVA: 0x0001E1F3 File Offset: 0x0001E1F3
			// (set) Token: 0x06000204 RID: 516 RVA: 0x0001E1FB File Offset: 0x0001E1FB
			public string customerPanelLink { get; set; }

			// Token: 0x17000060 RID: 96
			// (get) Token: 0x06000205 RID: 517 RVA: 0x0001E204 File Offset: 0x0001E204
			// (set) Token: 0x06000206 RID: 518 RVA: 0x0001E20C File Offset: 0x0001E20C
			public string downloadLink { get; set; }
		}

		// Token: 0x02000029 RID: 41
		public class user_data_class
		{
			// Token: 0x17000061 RID: 97
			// (get) Token: 0x06000208 RID: 520 RVA: 0x0001E21E File Offset: 0x0001E21E
			// (set) Token: 0x06000209 RID: 521 RVA: 0x0001E226 File Offset: 0x0001E226
			public string username { get; set; }

			// Token: 0x17000062 RID: 98
			// (get) Token: 0x0600020A RID: 522 RVA: 0x0001E22F File Offset: 0x0001E22F
			// (set) Token: 0x0600020B RID: 523 RVA: 0x0001E237 File Offset: 0x0001E237
			public string ip { get; set; }

			// Token: 0x17000063 RID: 99
			// (get) Token: 0x0600020C RID: 524 RVA: 0x0001E240 File Offset: 0x0001E240
			// (set) Token: 0x0600020D RID: 525 RVA: 0x0001E248 File Offset: 0x0001E248
			public string hwid { get; set; }

			// Token: 0x17000064 RID: 100
			// (get) Token: 0x0600020E RID: 526 RVA: 0x0001E251 File Offset: 0x0001E251
			// (set) Token: 0x0600020F RID: 527 RVA: 0x0001E259 File Offset: 0x0001E259
			public string createdate { get; set; }

			// Token: 0x17000065 RID: 101
			// (get) Token: 0x06000210 RID: 528 RVA: 0x0001E262 File Offset: 0x0001E262
			// (set) Token: 0x06000211 RID: 529 RVA: 0x0001E26A File Offset: 0x0001E26A
			public string lastlogin { get; set; }

			// Token: 0x17000066 RID: 102
			// (get) Token: 0x06000212 RID: 530 RVA: 0x0001E273 File Offset: 0x0001E273
			// (set) Token: 0x06000213 RID: 531 RVA: 0x0001E27B File Offset: 0x0001E27B
			public List<api.Data> subscriptions { get; set; }
		}

		// Token: 0x0200002A RID: 42
		public class Data
		{
			// Token: 0x17000067 RID: 103
			// (get) Token: 0x06000215 RID: 533 RVA: 0x0001E28D File Offset: 0x0001E28D
			// (set) Token: 0x06000216 RID: 534 RVA: 0x0001E295 File Offset: 0x0001E295
			public string subscription { get; set; }

			// Token: 0x17000068 RID: 104
			// (get) Token: 0x06000217 RID: 535 RVA: 0x0001E29E File Offset: 0x0001E29E
			// (set) Token: 0x06000218 RID: 536 RVA: 0x0001E2A6 File Offset: 0x0001E2A6
			public string expiry { get; set; }

			// Token: 0x17000069 RID: 105
			// (get) Token: 0x06000219 RID: 537 RVA: 0x0001E2AF File Offset: 0x0001E2AF
			// (set) Token: 0x0600021A RID: 538 RVA: 0x0001E2B7 File Offset: 0x0001E2B7
			public string timeleft { get; set; }
		}

		// Token: 0x0200002B RID: 43
		public class response_class
		{
			// Token: 0x1700006A RID: 106
			// (get) Token: 0x0600021C RID: 540 RVA: 0x0001E2C9 File Offset: 0x0001E2C9
			// (set) Token: 0x0600021D RID: 541 RVA: 0x0001E2D1 File Offset: 0x0001E2D1
			public bool success { get; set; }

			// Token: 0x1700006B RID: 107
			// (get) Token: 0x0600021E RID: 542 RVA: 0x0001E2DA File Offset: 0x0001E2DA
			// (set) Token: 0x0600021F RID: 543 RVA: 0x0001E2E2 File Offset: 0x0001E2E2
			public string message { get; set; }
		}
	}
}

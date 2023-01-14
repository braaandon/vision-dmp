using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;

namespace KeyAuth
{
	// Token: 0x02000005 RID: 5
	public class json_wrapper
	{
		// Token: 0x0600003A RID: 58 RVA: 0x00004618 File Offset: 0x00004618
		public static bool is_serializable(Type to_check)
		{
			return to_check.IsSerializable || to_check.IsDefined(typeof(DataContractAttribute), true);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00004638 File Offset: 0x00004638
		public json_wrapper(object obj_to_work_with)
		{
			this.current_object = obj_to_work_with;
			Type type = this.current_object.GetType();
			this.serializer = new DataContractJsonSerializer(type);
			bool flag = !json_wrapper.is_serializable(type);
			if (flag)
			{
				throw new Exception(string.Format("the object {0} isn't a serializable", this.current_object));
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00004690 File Offset: 0x00004690
		public object string_to_object(string json)
		{
			byte[] bytes = Encoding.Default.GetBytes(json);
			object result;
			using (MemoryStream memoryStream = new MemoryStream(bytes))
			{
				result = this.serializer.ReadObject(memoryStream);
			}
			return result;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000046DC File Offset: 0x000046DC
		public T string_to_generic<T>(string json)
		{
			return (T)((object)this.string_to_object(json));
		}

		// Token: 0x04000011 RID: 17
		private DataContractJsonSerializer serializer;

		// Token: 0x04000012 RID: 18
		private object current_object;
	}
}

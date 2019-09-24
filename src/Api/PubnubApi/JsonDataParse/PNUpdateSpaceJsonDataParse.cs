﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PubnubApi
{
    internal static class PNUpdateSpaceJsonDataParse
    {
        internal static PNUpdateSpaceResult GetObject(List<object> listObject)
        {
            PNUpdateSpaceResult result = null;
            Dictionary<string, object> updateSpaceDicObj = JsonDataParseInternalUtil.ConvertToDictionaryObject(listObject[1]);
            if (updateSpaceDicObj != null && updateSpaceDicObj.ContainsKey("data"))
            {
                result = new PNUpdateSpaceResult();

                Dictionary<string, object> getCreateSpaceDataDic = JsonDataParseInternalUtil.ConvertToDictionaryObject(updateSpaceDicObj["data"]);
                if (getCreateSpaceDataDic != null && getCreateSpaceDataDic.Count > 0)
                {
                    result.Id = getCreateSpaceDataDic.ContainsKey("id") && getCreateSpaceDataDic["id"] != null ? getCreateSpaceDataDic["id"].ToString() : null;
                    result.Name = getCreateSpaceDataDic.ContainsKey("name") && getCreateSpaceDataDic["name"] != null ? getCreateSpaceDataDic["name"].ToString() : null;
                    result.Description = getCreateSpaceDataDic.ContainsKey("description") && getCreateSpaceDataDic["description"] != null ? getCreateSpaceDataDic["description"].ToString() : null;
                    result.Created = getCreateSpaceDataDic.ContainsKey("created") && getCreateSpaceDataDic["created"] != null ? getCreateSpaceDataDic["created"].ToString() : null;
                    result.Updated = getCreateSpaceDataDic.ContainsKey("updated") && getCreateSpaceDataDic["updated"] != null ? getCreateSpaceDataDic["updated"].ToString() : null;
                    if (getCreateSpaceDataDic.ContainsKey("custom"))
                    {
                        result.Custom = JsonDataParseInternalUtil.ConvertToDictionaryObject(getCreateSpaceDataDic["custom"]);
                    }
                }
            }

            return result;
        }
    }
}
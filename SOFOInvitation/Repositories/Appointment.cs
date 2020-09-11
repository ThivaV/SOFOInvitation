using Microsoft.Office365.OutlookServices;
using SOFOInvitation.Interfaces;
using SOFOInvitation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Text.Json;

namespace SOFOInvitation.Repositories
{
    public class Appointment<T> : IAppointment<T> where T : class
    {
        public Appointment() { }
        
        public async Task<Appointment> CreateAppointment()
        {
            try
            {
                var url = "https://sod.superoffice.com/Cust30884/api/v1/Appointment";
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", "");
                    HttpResponseMessage response = await client.PostAsync(url, null);
                    response.EnsureSuccessStatusCode();

                    string accessResponse = await response.Content.ReadAsStringAsync();

                    return null;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<Event> GetEvent(string eventId) 
        {
            try
            {
                var url = "https://outlook.office.com/api/v2.0/me/events/" + $"{eventId}";
                var token = "eyJ0eXAiOiJKV1QiLCJub25jZSI6IlRleTU0ckNxTEdMcC1JTm90U1ZodzhEOEFVNjMwdmVOZzVYMWlHWjJQYWMiLCJhbGciOiJSUzI1NiIsIng1dCI6ImppYk5ia0ZTU2JteFBZck45Q0ZxUms0SzRndyIsImtpZCI6ImppYk5ia0ZTU2JteFBZck45Q0ZxUms0SzRndyJ9.eyJhdWQiOiJodHRwczovL291dGxvb2sub2ZmaWNlLmNvbSIsImlzcyI6Imh0dHBzOi8vc3RzLndpbmRvd3MubmV0L2NhZWY3Nzg1LWMwNzMtNDQ1My04YjQ3LTY0MzJiNmI1YjEwZi8iLCJpYXQiOjE1OTkwNDI1NjIsIm5iZiI6MTU5OTA0MjU2MiwiZXhwIjoxNTk5MDQ2NDYyLCJhY2N0IjowLCJhY3IiOiIxIiwiYWlvIjoiQVZRQXEvOFFBQUFBaFl5bnlHdVV5OWVsZncvZFRIaDNDcG9ZSXQ0YUZQcGdpdmlaN2pMb09mc0cwbHQ5eUVnWC83S3dmcEFFWlhKM1JiVmJyUlp2Z25TTjdYSnc1ZTJFdVVWT1hDSUsydjUzVC9qamwwSnNiMUk9IiwiYW1yIjpbInB3ZCIsIm1mYSJdLCJhcHBfZGlzcGxheW5hbWUiOiJPQXV0aCBTYW5kYm94IiwiYXBwaWQiOiIzMjYxM2ZjNS1lN2FjLTQ4OTQtYWM5NC1mYmMzOWM5ZjNlNGEiLCJhcHBpZGFjciI6IjEiLCJlbmZwb2xpZHMiOltdLCJmYW1pbHlfbmFtZSI6IlZhcmF0aGFyYWphbiIsImdpdmVuX25hbWUiOiJUaGl2YWhhcmFuIiwiaXBhZGRyIjoiMTIzLjIzMS41OC4xMjIiLCJuYW1lIjoiVGhpdmFoYXJhbiBWYXJhdGhhcmFqYW4iLCJvaWQiOiIzOGM4ZjE4Yi02ODdlLTQ1ZGUtODVjYS03ODVhOGRjYWY1M2MiLCJvbnByZW1fc2lkIjoiUy0xLTUtMjEtMjEzMjAzOTUwOS0xMTM5MjI5MjYyLTYwMjk1Njk2LTI2NDg0IiwicHVpZCI6IjEwMDMzRkZGQUFCQkFCOTgiLCJyaCI6IjAuQUFBQWhYZnZ5blBBVTBTTFIyUXl0cld4RDhVX1lUS3M1NVJJckpUN3c1eWZQa3BIQVBvLiIsInNjcCI6IkNhbGVuZGFycy5SZWFkV3JpdGUgQ2FsZW5kYXJzLlJlYWRXcml0ZS5TaGFyZWQgQ29udGFjdHMuUmVhZFdyaXRlIENvbnRhY3RzLlJlYWRXcml0ZS5TaGFyZWQgTWFpbC5SZWFkV3JpdGUgTWFpbC5SZWFkV3JpdGUuU2hhcmVkIE1haWwuU2VuZCBNYWlsLlNlbmQuU2hhcmVkIE1haWxib3hTZXR0aW5ncy5SZWFkV3JpdGUgUGVvcGxlLlJlYWQgVGFza3MuUmVhZFdyaXRlIFRhc2tzLlJlYWRXcml0ZS5TaGFyZWQgVXNlci5SZWFkQmFzaWMuQWxsIiwic2lkIjoiNGE5YjE5MTktNmViNS00ZjJjLWI1MDctOTRlODY0MWI2NzhmIiwic3ViIjoiY2I5ZmtaMDREQWxIQ2phemYyNEw5bXp0azJMY1pDd3U1TnVKNWRUTzgwMCIsInRpZCI6ImNhZWY3Nzg1LWMwNzMtNDQ1My04YjQ3LTY0MzJiNmI1YjEwZiIsInVuaXF1ZV9uYW1lIjoiVGhpdmFoYXJhbnZAc3VwZXJvZmZpY2UuY29tIiwidXBuIjoiVGhpdmFoYXJhbnZAc3VwZXJvZmZpY2UuY29tIiwidXRpIjoiX0dFX0d5Ymx1a3FLem5NaWVGa2xBQSIsInZlciI6IjEuMCJ9.feb0Wi2Tvy9tPzQhZhXyGy5TpJ0C9ZGfLBRfN_04BSdslCv9MqAZLRtrCwTQyKQpeDLmw4Ci3jnLPFyg8h0ouzGi-hWSIVSAbFvhIZnJVEXWQt3yzAi_NV9bakuQiI8YtcnxJMaUm88kr819MaEWUpywfVXFZbXcHFRaZ5JGjIMLCc8aPEh__LHhEz9OsXapa1FfjP7DkXev8-EkteP821CsQwYOI0Ks7Zy1kHFfw6ocWrnBObsPyyANFjN6-nkIwh2M-2qlyB1uRyKuSr_SJHpAN9CWsQZOLgJTBm-3QRWdVLUWpPrxUbhvx7ys_sfz_jpsaPrnQoM2kXNlTKrQ_g.eyJhdWQiOiJodHRwczovL291dGxvb2sub2ZmaWNlLmNvbSIsImlzcyI6Imh0dHBzOi8vc3RzLndpbmRvd3MubmV0L2NhZWY3Nzg1LWMwNzMtNDQ1My04YjQ3LTY0MzJiNmI1YjEwZi8iLCJpYXQiOjE1OTkwMzgyNTksIm5iZiI6MTU5OTAzODI1OSwiZXhwIjoxNTk5MDQyMTU5LCJhY2N0IjowLCJhY3IiOiIxIiwiYWlvIjoiQVZRQXEvOFFBQUFBK2V2WDZrbG5JNm5CY0lva09hTHN2NkFtaXYzWjdhM2tFUVJTV0k0UGRVNlJ2WTlQQTBMSGI4RFlNVmtFSTVNZlN4a3BBbVR0aVFScllaTWZnV3dibnB2Nm5yWnppWUlVdWs3WGdVanJmL3M9IiwiYW1yIjpbInB3ZCIsIm1mYSJdLCJhcHBfZGlzcGxheW5hbWUiOiJPQXV0aCBTYW5kYm94IiwiYXBwaWQiOiIzMjYxM2ZjNS1lN2FjLTQ4OTQtYWM5NC1mYmMzOWM5ZjNlNGEiLCJhcHBpZGFjciI6IjEiLCJlbmZwb2xpZHMiOltdLCJmYW1pbHlfbmFtZSI6IlZhcmF0aGFyYWphbiIsImdpdmVuX25hbWUiOiJUaGl2YWhhcmFuIiwiaXBhZGRyIjoiMTIzLjIzMS41OC4xMjIiLCJuYW1lIjoiVGhpdmFoYXJhbiBWYXJhdGhhcmFqYW4iLCJvaWQiOiIzOGM4ZjE4Yi02ODdlLTQ1ZGUtODVjYS03ODVhOGRjYWY1M2MiLCJvbnByZW1fc2lkIjoiUy0xLTUtMjEtMjEzMjAzOTUwOS0xMTM5MjI5MjYyLTYwMjk1Njk2LTI2NDg0IiwicHVpZCI6IjEwMDMzRkZGQUFCQkFCOTgiLCJyaCI6IjAuQUFBQWhYZnZ5blBBVTBTTFIyUXl0cld4RDhVX1lUS3M1NVJJckpUN3c1eWZQa3BIQVBvLiIsInNjcCI6IkNhbGVuZGFycy5SZWFkV3JpdGUgQ2FsZW5kYXJzLlJlYWRXcml0ZS5TaGFyZWQgQ29udGFjdHMuUmVhZFdyaXRlIENvbnRhY3RzLlJlYWRXcml0ZS5TaGFyZWQgTWFpbC5SZWFkV3JpdGUgTWFpbC5SZWFkV3JpdGUuU2hhcmVkIE1haWwuU2VuZCBNYWlsLlNlbmQuU2hhcmVkIE1haWxib3hTZXR0aW5ncy5SZWFkV3JpdGUgUGVvcGxlLlJlYWQgVGFza3MuUmVhZFdyaXRlIFRhc2tzLlJlYWRXcml0ZS5TaGFyZWQgVXNlci5SZWFkQmFzaWMuQWxsIiwic2lkIjoiNGE5YjE5MTktNmViNS00ZjJjLWI1MDctOTRlODY0MWI2NzhmIiwic3ViIjoiY2I5ZmtaMDREQWxIQ2phemYyNEw5bXp0azJMY1pDd3U1TnVKNWRUTzgwMCIsInRpZCI6ImNhZWY3Nzg1LWMwNzMtNDQ1My04YjQ3LTY0MzJiNmI1YjEwZiIsInVuaXF1ZV9uYW1lIjoiVGhpdmFoYXJhbnZAc3VwZXJvZmZpY2UuY29tIiwidXBuIjoiVGhpdmFoYXJhbnZAc3VwZXJvZmZpY2UuY29tIiwidXRpIjoiaHhjT2lvTE12VS1vcEJFb1ZtQWhBQSIsInZlciI6IjEuMCJ9.ZsQJ-Yfd-wzxF0nCJWOdiokEN5_UuFZKikJJj_qWU3H5cHzJI02-WmY5EEDmGRf54xn9jt24Nquw9i_F9KQRmXZGPhCMOFcUL6t2_8SBWbNg0tNpCWx3o2bp4ne6_f818d62By-JK4cyxaR_nET-ZADQyz0oY3qr1555XZ-dAX8UJY__JNII6HZSyJPx5P3jm08vyxCJd_IeO8Rr2dwCgOnc67RJu7e5kr0U3lyqwCvl7Y3BBhK0Fe6zOwl9Pvy8-rNEFgYMVYB8YqGetPrZNnPilXTogKepXbGbNEh_IllgWa7SVOcRPsZVL1vjDdEeuBoFnAb3IGIL51_3F1eaaw";

                return null;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}

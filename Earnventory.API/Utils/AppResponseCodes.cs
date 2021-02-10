﻿namespace DevICGlobal.Utils
{
    public class AppResponseCodes
    {
        public const int HTTP_CONTINUE = 100;
        public const int HTTP_SWITCHING_PROTOCOLS = 101;
        public const int HTTP_PROCESSING = 102; // RFC2518
        public const int HTTP_EARLY_HINTS = 103; // RFC8297
        public const int HTTP_OK = 200;
        public const int HTTP_CREATED = 201;
        public const int HTTP_ACCEPTED = 202;
        public const int HTTP_NON_AUTHORITATIVE_INFORMATION = 203;
        public const int HTTP_NO_CONTENT = 204;
        public const int HTTP_RESET_CONTENT = 205;
        public const int HTTP_PARTIAL_CONTENT = 206;
        public const int HTTP_MULTI_STATUS = 207; // RFC4918
        public const int HTTP_ALREADY_REPORTED = 208; // RFC5842
        public const int HTTP_IM_USED = 226; // RFC3229
        public const int HTTP_MULTIPLE_CHOICES = 300;
        public const int HTTP_MOVED_PERMANENTLY = 301;
        public const int HTTP_FOUND = 302;
        public const int HTTP_SEE_OTHER = 303;
        public const int HTTP_NOT_MODIFIED = 304;
        public const int HTTP_USE_PROXY = 305;
        public const int HTTP_RESERVED = 306;
        public const int HTTP_TEMPORARY_REDIRECT = 307;
        public const int HTTP_PERMANENTLY_REDIRECT = 308; // RFC7238
        public const int HTTP_BAD_REQUEST = 400;
        public const int HTTP_UNAUTHORIZED = 401;
        public const int HTTP_PAYMENT_REQUIRED = 402;
        public const int HTTP_FORBIDDEN = 403;
        public const int HTTP_NOT_FOUND = 404;
        public const int HTTP_METHOD_NOT_ALLOWED = 405;
        public const int HTTP_NOT_ACCEPTABLE = 406;
        public const int HTTP_PROXY_AUTHENTICATION_REQUIRED = 407;
        public const int HTTP_REQUEST_TIMEOUT = 408;
        public const int HTTP_CONFLICT = 409;
        public const int HTTP_GONE = 410;
        public const int HTTP_LENGTH_REQUIRED = 411;
        public const int HTTP_PRECONDITION_FAILED = 412;
        public const int HTTP_REQUEST_ENTITY_TOO_LARGE = 413;
        public const int HTTP_REQUEST_URI_TOO_LONG = 414;
        public const int HTTP_UNSUPPORTED_MEDIA_TYPE = 415;
        public const int HTTP_REQUESTED_RANGE_NOT_SATISFIABLE = 416;
        public const int HTTP_EXPECTATION_FAILED = 417;
        public const int HTTP_I_AM_A_TEAPOT = 418; // RFC2324
        public const int HTTP_MISDIRECTED_REQUEST = 421; // RFC7540
        public const int HTTP_UNPROCESSABLE_ENTITY = 422; // RFC4918
        public const int HTTP_LOCKED = 423; // RFC4918
        public const int HTTP_FAILED_DEPENDENCY = 424;
    }
}
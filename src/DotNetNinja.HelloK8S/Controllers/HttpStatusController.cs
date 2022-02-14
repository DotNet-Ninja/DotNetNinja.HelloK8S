using System.Linq;
using System.Net;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using DotNetNinja.HelloK8S.Models;

namespace DotNetNinja.HelloK8S.Controllers;

public class HttpStatusController: Controller
{
    private readonly ILogger<HttpStatusController> _logger;

    public HttpStatusController(ILogger<HttpStatusController> logger)
    {
        _logger = logger;
    }

    // Status 200 - O K
    public IActionResult OK()
    {
        return StatusView(HttpStatusCode.OK);
    }

    // Status 400 - Bad Request
    public new IActionResult BadRequest()
    {
        return StatusView(HttpStatusCode.BadRequest);
    }

    // Status 401 - Unauthorized
    public new IActionResult Unauthorized()
    {
        return StatusView(HttpStatusCode.Unauthorized);
    }

    // Status 402 - Payment Required
    public IActionResult PaymentRequired()
    {
        return StatusView(HttpStatusCode.PaymentRequired);
    }

    // Status 403 - Forbidden
    public IActionResult Forbidden()
    {
        return StatusView(HttpStatusCode.Forbidden);
    }

    // Status 404 - Not Found
    public new IActionResult NotFound()
    {
        return StatusView(HttpStatusCode.NotFound);
    }

    // Status 405 - Method Not Allowed
    public IActionResult MethodNotAllowed()
    {
        return StatusView(HttpStatusCode.MethodNotAllowed);
    }

    // Status 406 - Not Acceptable
    public IActionResult NotAcceptable()
    {
        return StatusView(HttpStatusCode.NotAcceptable);
    }

    // Status 407 - Proxy Authentication Required
    public IActionResult ProxyAuthenticationRequired()
    {
        return StatusView(HttpStatusCode.ProxyAuthenticationRequired);
    }

    // Status 408 - Request Timeout
    public IActionResult RequestTimeout()
    {
        return StatusView(HttpStatusCode.RequestTimeout);
    }

    // Status 409 - Conflict
    public new IActionResult Conflict()
    {
        return StatusView(HttpStatusCode.Conflict);
    }

    // Status 410 - Gone
    public IActionResult Gone()
    {
        return StatusView(HttpStatusCode.Gone);
    }

    // Status 411 - Length Required
    public IActionResult LengthRequired()
    {
        return StatusView(HttpStatusCode.LengthRequired);
    }

    // Status 412 - Precondition Failed
    public IActionResult PreconditionFailed()
    {
        return StatusView(HttpStatusCode.PreconditionFailed);
    }

    // Status 413 - Request Entity Too Large
    public IActionResult RequestEntityTooLarge()
    {
        return StatusView(HttpStatusCode.RequestEntityTooLarge);
    }

    // Status 414 - Request Uri Too Long
    public IActionResult RequestUriTooLong()
    {
        return StatusView(HttpStatusCode.RequestUriTooLong);
    }

    // Status 415 - Unsupported Media Type
    public IActionResult UnsupportedMediaType()
    {
        return StatusView(HttpStatusCode.UnsupportedMediaType);
    }

    // Status 416 - Requested Range Not Satisfiable
    public IActionResult RequestedRangeNotSatisfiable()
    {
        return StatusView(HttpStatusCode.RequestedRangeNotSatisfiable);
    }

    // Status 417 - Expectation Failed
    public IActionResult ExpectationFailed()
    {
        return StatusView(HttpStatusCode.ExpectationFailed);
    }

    // Status 421 - Misdirected Request
    public IActionResult MisdirectedRequest()
    {
        return StatusView(HttpStatusCode.MisdirectedRequest);
    }

    // Status 422 - Unprocessable Entity
    public new IActionResult UnprocessableEntity()
    {
        return StatusView(HttpStatusCode.UnprocessableEntity);
    }

    // Status 423 - Locked
    public IActionResult Locked()
    {
        return StatusView(HttpStatusCode.Locked);
    }

    // Status 424 - Failed Dependency
    public IActionResult FailedDependency()
    {
        return StatusView(HttpStatusCode.FailedDependency);
    }

    // Status 426 - Upgrade Required
    public IActionResult UpgradeRequired()
    {
        return StatusView(HttpStatusCode.UpgradeRequired);
    }

    // Status 428 - Precondition Required
    public IActionResult PreconditionRequired()
    {
        return StatusView(HttpStatusCode.PreconditionRequired);
    }

    // Status 429 - Too Many Requests
    public IActionResult TooManyRequests()
    {
        return StatusView(HttpStatusCode.TooManyRequests);
    }

    // Status 431 - Request Header Fields Too Large
    public IActionResult RequestHeaderFieldsTooLarge()
    {
        return StatusView(HttpStatusCode.RequestHeaderFieldsTooLarge);
    }

    // Status 451 - Unavailable For Legal Reasons
    public IActionResult UnavailableForLegalReasons()
    {
        return StatusView(HttpStatusCode.UnavailableForLegalReasons);
    }

    // Status 500 - Internal Server Error
    public IActionResult InternalServerError()
    {
        return StatusView(HttpStatusCode.InternalServerError);
    }

    // Status 501 - Not Implemented
    public IActionResult NotImplemented()
    {
        return StatusView(HttpStatusCode.NotImplemented);
    }

    // Status 502 - Bad Gateway
    public IActionResult BadGateway()
    {
        return StatusView(HttpStatusCode.BadGateway);
    }

    // Status 503 - Service Unavailable
    public IActionResult ServiceUnavailable()
    {
        return StatusView(HttpStatusCode.ServiceUnavailable);
    }

    // Status 504 - Gateway Timeout
    public IActionResult GatewayTimeout()
    {
        return StatusView(HttpStatusCode.GatewayTimeout);
    }

    // Status 505 - Http Version Not Supported
    public IActionResult HttpVersionNotSupported()
    {
        return StatusView(HttpStatusCode.HttpVersionNotSupported);
    }

    // Status 506 - Variant Also Negotiates
    public IActionResult VariantAlsoNegotiates()
    {
        return StatusView(HttpStatusCode.VariantAlsoNegotiates);
    }

    // Status 507 - Insufficient Storage
    public IActionResult InsufficientStorage()
    {
        return StatusView(HttpStatusCode.InsufficientStorage);
    }

    // Status 508 - Loop Detected
    public IActionResult LoopDetected()
    {
        return StatusView(HttpStatusCode.LoopDetected);
    }

    // Status 510 - Not Extended
    public IActionResult NotExtended()
    {
        return StatusView(HttpStatusCode.NotExtended);
    }

    // Status 511 - Network Authentication Required
    public IActionResult NetworkAuthenticationRequired()
    {
        return StatusView(HttpStatusCode.NetworkAuthenticationRequired);
    }

    public PartialViewResult StatusLinks()
    {
        var model = UIHelper.HttpStatusDescriptions.Keys.ToList();
        return PartialView(model);
    }

    private ViewResult StatusView(HttpStatusCode status)
    {
        var model = new HttpStatusModel(status);
        var view = View("status", model);
        return view;
    }
}
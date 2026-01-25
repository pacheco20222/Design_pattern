class Subject(ABC):
    @abstractmethod
    def request(self): pass

class RealSubject(Subject):
    def request(self): print("RealSubject: Handling request.")

class Proxy(Subject):
    def __init__(self, real_subject: RealSubject):
        self._real_subject = real_subject

    def request(self):
        print("Proxy: Logging access before calling RealSubject.")
        self._real_subject.request()